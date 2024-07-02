using EventGate.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Data.Repositories.Interface
{
    public interface IEventRuleRepository
    {
        Task<List<EventRule>> GetAllAsync();
        Task<EventRule> GetByIdAsync(string eventRuleId);
        Task<int> AddAsync(string user, EventRule addEventRule);
        Task<int> UpdateAsync(string user, string eventRuleId, EventRule updateEventRule);
        Task<int> DeleteAsync(string user, string eventRuleId);
    }
}
