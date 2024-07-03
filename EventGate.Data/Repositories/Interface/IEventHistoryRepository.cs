using EventGate.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Data.Repositories.Interface
{
    public interface IEventHistoryRepository
    {
        Task<List<EventHistory>> GetAllAsync();
        Task<int> AddEventHistoryAsync(EventHistory userHistory);
    }
}
