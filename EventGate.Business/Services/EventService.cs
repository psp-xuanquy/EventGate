﻿using AutoMapper;
using EventGate.Business.Models.DTOs.Request;
using EventGate.Business.Services.Interface;
using EventGate.Data.Entity;
using EventGate.Data.Repositories;
using EventGate.Data.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Business.Services
{
    public class EventService : IEventService
    {
        private readonly IEventRepository _eventRepository;
        private readonly IEventTypeRepository _eventTypeRepository;
        private readonly IUserPropository _userRepository;
        private readonly IMapper _mapper;

        public EventService(IEventRepository eventRepository, IUserPropository userRepository, IMapper mapper, IEventTypeRepository eventTypeRepository)
        {
            _eventRepository = eventRepository;
            _userRepository = userRepository;
            _mapper = mapper;
            _eventTypeRepository = eventTypeRepository;
        }

        // Get all Event
        public async Task<List<EventDTO>> GetAllEventsAsync()
        {
            List<Event> events = await _eventRepository.GetAllAsync();
            return _mapper.Map<List<EventDTO>>(events);
        }

        // Get Event by ID
        public async Task<EventDTO> GetEventByIdAsync(string eventId)
        {
            var existingEvent = await _eventRepository.GetByIdAsync(eventId);
            if (existingEvent == null)
            {
                throw new Exception($"Event with ID ( {eventId} ) NOT FOUND");
            }

            return _mapper.Map<EventDTO>(existingEvent);
        }

        // Add Event
        public async Task<int> AddEventAsync(string user, EventDTO addEventDto)
        {
            var existingEventType = await _eventTypeRepository.GetByIdAsync(addEventDto.EventTypeID);
            if (existingEventType == null)
            {
                throw new Exception($"EventType with the ID '{addEventDto.EventTypeID}' DOES NOT EXIST");
            }

            var eventExist = _mapper.Map<Event>(addEventDto);
            return await _eventRepository.AddAsync(user, eventExist);
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

            return await _eventRepository.DeleteAsync(user, eventId);
        }
    }
}
