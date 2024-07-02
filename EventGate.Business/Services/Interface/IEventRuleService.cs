using EventGate.Business.Models.DTOs.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Business.Services.Interface
{
    public interface IEventRuleService
    {
        Task<List<EventRuleDTO>> GetAllEventRulesAsync();
        Task<EventRuleDTO> GetEventRuleByIdAsync(string eventRuleId);
        Task<int> AddEventRuleAsync(string user, EventRuleDTO addEventRuleDto);
        Task<int> UpdateEventRuleAsync(string user, string eventRuleId, EventRuleDTO updateEventRuleDto);
        Task<int> DeleteEventRuleAsync(string user, string eventRuleId);
    }
}
