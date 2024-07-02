using AutoMapper;
using EventGate.Business.Models.DTOs.Request;
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
    public class EventRuleService : IEventRuleService
    {
        private readonly IEventRuleRepository _eventRuleRepository;
        private readonly IEventTypeService _eventTypeRepository;
        private readonly IUserPropository _userRepository;
        private readonly IMapper _mapper;

        public EventRuleService(IEventRuleRepository eventRuleRepository, IUserPropository userRepository, IMapper mapper, IEventTypeService eventTypeRepository)
        {
            _eventRuleRepository = eventRuleRepository;
            _userRepository = userRepository;
            _mapper = mapper;
            _eventTypeRepository = eventTypeRepository;
        }

        // Get all EventRule
        public async Task<List<EventRuleDTO>> GetAllEventRulesAsync()
        {
            List<EventRule> eventRules = await _eventRuleRepository.GetAllAsync();
            return _mapper.Map<List<EventRuleDTO>>(eventRules);
        }

        // Get EventRule by ID
        public async Task<EventRuleDTO> GetEventRuleByIdAsync(string eventRuleId)
        {
            EventRule eventRule = await _eventRuleRepository.GetByIdAsync(eventRuleId);
            if (eventRule == null)
            {
                throw new Exception($"EventRule with ID ( {eventRuleId} ) NOT FOUND");
            }

            return _mapper.Map<EventRuleDTO>(eventRule);
        }

        // Add EventRule
        public async Task<int> AddEventRuleAsync(string user, EventRuleDTO addEventRuleDto)
        {
            var existingEventType = await _eventTypeRepository.GetEventTypeByIdAsync(addEventRuleDto.EventTypeID);
            if (existingEventType == null)
            {
                throw new Exception($"EventType with the ID '{addEventRuleDto.EventTypeID}' DOES NOT EXIST");
            }

            var eventRule = _mapper.Map<EventRule>(addEventRuleDto);
            return await _eventRuleRepository.AddAsync(user, eventRule);
        }

        // Update EventRule
        public async Task<int> UpdateEventRuleAsync(string user, string eventRuleId, EventRuleDTO updateEventRuleDto)
        {
            var existingEventType = await _eventTypeRepository.GetEventTypeByIdAsync(updateEventRuleDto.EventTypeID);
            if (existingEventType == null)
            {
                throw new Exception($"EventType with the ID '{updateEventRuleDto.EventTypeID}' DOES NOT EXIST");
            }

            var eventRule = _mapper.Map<EventRule>(updateEventRuleDto);
            return await _eventRuleRepository.UpdateAsync(user, eventRuleId, eventRule);
        }

        // Delete EventRule
        public async Task<int> DeleteEventRuleAsync(string user, string eventRuleId)
        {
            var existingEventRule = await _eventRuleRepository.GetByIdAsync(eventRuleId);
            if (existingEventRule == null)
            {
                throw new Exception($"EventRule with ID ( {eventRuleId} ) NOT FOUND.");
            }

            return await _eventRuleRepository.DeleteAsync(user, eventRuleId);
        }
    }
}
