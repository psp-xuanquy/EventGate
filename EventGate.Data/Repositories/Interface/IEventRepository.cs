using EventGate.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Data.Repositories.Interface
{
    public interface IEventRepository
    {
        Task<List<Event>> GetAllAsync();
        Task<Event> GetByIdAsync(string eventId);
        Task<int> AddAsync(string user, Event addEvent);
        Task<int> UpdateAsync(string user, string eventId, Event updateEvent);
        Task<int> DeleteAsync(string user, string eventId);
    }
}
