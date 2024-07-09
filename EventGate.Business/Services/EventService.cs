using AutoMapper;
using EventGate.Business.Models.DTOs.Request;
using EventGate.Business.Models.DTOs.Request.EventHistory;
using EventGate.Business.Models.DTOs.Request.User;
using EventGate.Business.Models.DTOs.Response;
using EventGate.Business.Models.DTOs.Response.Event;
using EventGate.Business.Services.Interface;
using EventGate.Data.Entity;
using EventGate.Data.Repositories;
using EventGate.Data.Repositories.Interface;
using Microsoft.Extensions.Logging;
using Org.BouncyCastle.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Business.Services
{
    public class EventService : IEventService
    {
        
        private List<char> chars = new List<char> { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J' };
        private readonly IEventRepository _eventRepository;
        private readonly IEventTypeRepository _eventTypeRepository;
        private readonly ITicketRepository _ticketRepository;
        private readonly IEventClubsRepository _eventClubsRepository;
        private readonly IClubRepository _clubRepository;
        private readonly IUserPropository _userRepository;
        private readonly IEventHistoryRepository _eventHistoryRepository;
        private readonly IMapper _mapper;
        private readonly ISeatRepository _seatRepository;

        public EventService(IEventRepository eventRepository, IUserPropository userRepository, IMapper mapper, IEventTypeRepository eventTypeRepository, IEventHistoryRepository eventHistoryRepository, ITicketRepository ticketRepository, IEventClubsRepository eventClubsRepository, IClubRepository clubRepository, ISeatRepository seatRepository)
        {
            _eventRepository = eventRepository;
            _userRepository = userRepository;
            _mapper = mapper;
            _eventTypeRepository = eventTypeRepository;
            _eventHistoryRepository = eventHistoryRepository;
            _ticketRepository = ticketRepository;
            _eventClubsRepository = eventClubsRepository;
            _clubRepository = clubRepository;
            _seatRepository = seatRepository;
        }

        // Get all Event
        public async Task<List<EventDTOResponse>> GetAllEventsAsync()
        {
            List<Event> events = await _eventRepository.GetAllAsync();
            return _mapper.Map<List<EventDTOResponse>>(events);
        }

        // Get Event by ID
        public async Task<EventDTOResponse> GetEventByIdAsync(string eventId)
        {
            var existingEvent = await _eventRepository.GetByIdAsync(eventId);
            if (existingEvent == null)
            {
                throw new Exception($"Event with ID ( {eventId} ) NOT FOUND");
            }
            return _mapper.Map<EventDTOResponse>(existingEvent);
        }

        // Get All Tickets by EventID
        public async Task<List<TicketResponseDTO>> GetTicketsByEventIdAsync(string eventId)
        {
            var tickets = await _eventRepository.GetTicketsByEventIdAsync(eventId);
            return _mapper.Map<List<TicketResponseDTO>>(tickets);
        }

        // Add Event
        public async Task<EventDTOResponse> AddEventAsync(string user, EventDTO addEventDto)
        {
            var existingEventType = await _eventTypeRepository.GetByIdAsync(addEventDto.EventTypeID);
            if (existingEventType == null)
            {
                throw new Exception($"EventType with the ID '{addEventDto.EventTypeID}' DOES NOT EXIST");
            }

            if(addEventDto.TicketQuantity > 100)
            {
                throw new Exception("Ticket quantity must be less than or equal to 30");
            }

            var eventExist = _mapper.Map<Event>(addEventDto);
            var result = await _eventRepository.AddAsync(user, eventExist);

            //var club = _clubRepository.GetClubByUserId(user);

            //if(club == null)
            //{
            //    throw new Exception("Your are not the President of any Club");
            //}

            //EventClub newEventClub = new EventClub();
            //newEventClub.EventID = eventExist.EventID;
            //newEventClub.ClubID = club.Id.ToString();

            //await _eventClubsRepository.AddEventClub(newEventClub);

            //if(result != 0)
            //{
            //    for(var i = 0; i < addEventDto.TicketQuantity; i++)
            //    {
            //        Ticket newTicket = new Ticket();
            //        newTicket.EventID = eventExist.EventID;
            //        newTicket.Price = addEventDto.Price??0;
            //        await _ticketRepository.AddAsync(user, newTicket);
            //    }
            //}
            int numberRow = addEventDto.TicketQuantity / 10;
            int checkQuantity = addEventDto.TicketQuantity % 10;
            if (checkQuantity != 0)
            {
                throw new Exception("Ticket quantity must be must be divisible by 10");
            }
            if (result != 0)
            {
                for (global::System.Int32 i = 0; i < numberRow; i++)
                {
                    for (global::System.Int32 j = 1; j < 11; j++)
                    {
                        Seat newSeat = new Seat();
                        newSeat.IsAvailable = true;
                        newSeat.Number = j;
                        newSeat.Row = chars[i].ToString();
                        newSeat.CreatedTime = DateTime.Now;
                        await _seatRepository.AddAsync(user, newSeat);
                        Ticket newTicket = new Ticket();
                        newTicket.EventID = eventExist.EventID;
                        newTicket.Price = addEventDto.Price ?? 0;
                        newTicket.SeatID = newSeat.SeatID;
                        await _ticketRepository.AddAsync(user, newTicket);
                    }
                }
            }


            return _mapper.Map<EventDTOResponse>(eventExist);
        }

        // Update Event
        public async Task<int> UpdateEventAsync(string user, string eventId, EventDTO updateEventDto)
        {
            var existingEventType = await _eventTypeRepository.GetByIdAsync(updateEventDto.EventTypeID);
            if (existingEventType == null)
            {
                throw new Exception($"EventType with the ID '{updateEventDto.EventTypeID}' DOES NOT EXIST");
            }

            var eventExist = _mapper.Map<Event>(updateEventDto);
            return await _eventRepository.UpdateAsync(user, eventId, eventExist);
        }

        // Delete Event
        public async Task<int> DeleteEventAsync(string user, string eventId)
        {
            var existingEvent = await _eventRepository.GetByIdAsync(eventId);
            if (existingEvent == null)
            {
                throw new Exception($"Event with ID ( {eventId} ) NOT FOUND.");
            }

            // Map Event to EventHistoryDTORequest
            var eventHistoryDTO = _mapper.Map<EventHistoryDTORequest>(existingEvent);

            // Map EventHistoryDTORequest to EventHistory entity
            var eventHistory = _mapper.Map<EventHistory>(eventHistoryDTO);

         
            await _eventHistoryRepository.AddEventHistoryAsync(eventHistory);

            return await _eventRepository.DeleteAsync(user, eventId);
        }
    }
}
