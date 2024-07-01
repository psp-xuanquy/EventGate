using EventGate.Business.Mappers;
using EventGate.Business.Models.DTOs.Request;
using EventGate.Data.Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EventGate.Data.Repositories.Interface;
using EventGate.Business.Services.Interface;
using AutoMapper;
using EventGate.Data.Repositories;

namespace EventGate.Business.Services
{
    public class TicketService : ITicketService
    {
        private readonly ITicketRepository _ticketRepository;
        private readonly ISeatRepository _seatRepository;
        //private readonly IEventRepository _voucherRepository;
        private readonly IMapper _mapper;

        public TicketService(ITicketRepository ticketRepository, ISeatRepository seatRepository, IMapper mapper)
        {
            _ticketRepository = ticketRepository;
            _seatRepository = seatRepository;
            _mapper = mapper;
        }

        // Get all Ticket
        public async Task<List<TicketDTO>> GetAllTicketsAsync()
        {
            var tickets = await _ticketRepository.GetAllAsync();
            return _mapper.Map<List<TicketDTO>>(tickets);
        }

        // Get Ticket by ID
        public async Task<TicketDTO> GetTicketByIdAsync(string ticketId)
        {
            var ticket = await _ticketRepository.GetByIdAsync(ticketId);
            if (ticket == null)
            {
                throw new Exception($"Ticket with ID ( {ticketId} ) NOT FOUND");
            }

            return _mapper.Map<TicketDTO>(ticket);
        }

        // Add Ticket
        public async Task<int> AddTicketAsync(string user, TicketDTO addTicketDto)
        {
            //var existingEvent = await _eventRepository.GetByIdAsync(addTicketDto.EventID);
            //if (existingEvent == null)
            //{
            //    throw new Exception($"Event with ID ( {addTicketDto.EventID} ) NOT FOUND.");
            //}

            var existingSeat = await _seatRepository.GetByIdAsync(addTicketDto.SeatID);
            if (existingSeat == null)
            {
                throw new Exception($"Seat with ID ( {addTicketDto.SeatID} ) NOT FOUND.");
            }

            if (await _ticketRepository.IsSeatAssociatedWithAnotherTicketAsync(addTicketDto.SeatID))
            {
                throw new Exception($"Seat with ID ( {addTicketDto.SeatID} ) is already ASSOCIATED with ANOTHER TICKET.");
            }

            var ticket = _mapper.Map<Ticket>(addTicketDto);
            return await _ticketRepository.AddAsync(user, ticket);
        }

        // Update Ticket
        public async Task<int> UpdateTicketAsync(string user, string ticketId, TicketDTO updateTicketDto)
        {
            var existingTicket = await _ticketRepository.GetByIdAsync(ticketId);
            if (existingTicket == null)
            {
                throw new Exception($"Ticket with ID ( {ticketId} ) NOT FOUND");
            }

            //var existingEvent = await _eventRepository.GetByIdAsync(updateTicketDto.EventID);
            //if (existingEvent == null)
            //{
            //    throw new Exception($"Event with ID ( {updateTicketDto.EventID} ) NOT FOUND.");
            //}

            var existingSeat = await _seatRepository.GetByIdAsync(updateTicketDto.SeatID);
            if (existingSeat == null)
            {
                throw new Exception($"Seat with ID ( {updateTicketDto.SeatID} ) NOT FOUND.");
            }

            if (await _ticketRepository.IsSeatAssociatedWithAnotherTicketAsync(updateTicketDto.SeatID))
            {
                throw new Exception($"Seat with ID ( {updateTicketDto.SeatID} ) is already ASSOCIATED with ANOTHER TICKET.");
            }

            var ticket = _mapper.Map<Ticket>(updateTicketDto);
            return await _ticketRepository.UpdateAsync(user, ticketId, ticket);
        }

        // Delete Ticket
        public async Task<int> DeleteTicketAsync(string user, string ticketId)
        {
            var existingTicket = await _ticketRepository.GetByIdAsync(ticketId);
            if (existingTicket == null)
            {
                throw new Exception($"Ticket with ID ( {ticketId} ) NOT FOUND");
            }

            return await _ticketRepository.DeleteAsync(user, ticketId);
        }
    }
}
