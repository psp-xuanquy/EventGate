using EventGate.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Data.Repositories.Interface
{
    public interface IEventTypeRepository
    {
        Task<List<EventType>> GetAllAsync();
        Task<EventType> GetByIdAsync(string eventTypeId);
        Task<EventType> GetByNameAsync(string eventTypeName);
        Task<int> AddAsync(string user, EventType addEventType);
        Task<int> UpdateAsync(string user, string eventTypeId, EventType updateEventType);
        Task<int> DeleteAsync(string user, string eventTypeId);
    }
}
