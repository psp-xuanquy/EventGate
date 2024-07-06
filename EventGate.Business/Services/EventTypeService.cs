using AutoMapper;
using EventGate.Business.Models.DTOs.Request;
using EventGate.Business.Models.DTOs.Response;
using EventGate.Business.Services.Interface;
using EventGate.Data.Entity;
using EventGate.Data.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Business.Services
{
    public class EventTypeService : IEventTypeService
    {
        private readonly IEventTypeRepository _eventTypeRepository;
        private readonly IMapper _mapper;

        public EventTypeService(IEventTypeRepository eventTypeRepository, IMapper mapper)
        {
            _eventTypeRepository = eventTypeRepository;
            _mapper = mapper;
        }

        // Get all EventType
        public async Task<List<EventTypeDTOResponse>> GetAllEventTypesAsync()
        {
            var eventTypes = await _eventTypeRepository.GetAllAsync();
            return _mapper.Map<List<EventTypeDTOResponse>>(eventTypes);
        }

        // Get EventType by ID
        public async Task<EventTypeDTOResponse> GetEventTypeByIdAsync(string eventTypeId)
        {
            var eventType = await _eventTypeRepository.GetByIdAsync(eventTypeId);
            if (eventType == null)
            {
                throw new Exception($"EventType with ID ( {eventTypeId} ) NOT FOUND");
            }
            return _mapper.Map<EventTypeDTOResponse>(eventType);
        }

        // Add EventType
        public async Task<int> AddEventTypeAsync(string user, EventTypeDTO addEventTypeDto)
        {
            var existingEventType = await _eventTypeRepository.GetByNameAsync(addEventTypeDto.EventTypeName);
            if (existingEventType != null)
            {
                throw new Exception($"EventType with {addEventTypeDto.EventTypeName} ALREADY EXISTS");
            }

            var eventType = _mapper.Map<EventType>(addEventTypeDto);
            return await _eventTypeRepository.AddAsync(user, eventType);
        }

        // Update EventType
        public async Task<int> UpdateEventTypeAsync(string user, string eventTypeId, EventTypeDTO updateEventTypeDto)
        {
            var existingEventType = await _eventTypeRepository.GetByIdAsync(eventTypeId);
            if (existingEventType == null)
            {
                throw new Exception($"EventType with ID ({eventTypeId}) NOT FOUND");
            }

            var conflictingEventType = await _eventTypeRepository.GetByNameAsync(updateEventTypeDto.EventTypeName);
            if (conflictingEventType != null && conflictingEventType.EventTypeID != eventTypeId)
            {
                throw new Exception($"EventType with {updateEventTypeDto.EventTypeName} ALREADY EXISTS");
            }

            var eventType = _mapper.Map<EventType>(updateEventTypeDto);
            return await _eventTypeRepository.UpdateAsync(user, eventTypeId, eventType);
        }

        // Delete EventType
        public async Task<int> DeleteEventTypeAsync(string user, string eventTypeId)
        {
            var existingEventType = await _eventTypeRepository.GetByIdAsync(eventTypeId);
            if (existingEventType == null)
            {
                throw new Exception($"EventType with ID ({eventTypeId}) NOT FOUND");
            }

            return await _eventTypeRepository.DeleteAsync(user, eventTypeId);
        }
    }
}
