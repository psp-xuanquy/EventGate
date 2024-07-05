using EventGate.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Data.Repositories.Interface
{
    public interface IEventFeedBackRepository 
    {
        Task<List<EventFeedback>> GetAllAsync();
        Task<List<EventFeedback>> GetAllDeletedAsync();

        Task<int> AddEventFeedBackAsync(EventFeedback eventFeedBack);
        Task<EventFeedback> GetByIdAsync(string id);
        Task<int> UpdateAsync(EventFeedback eventFeedBack);
        Task<int> DeleteAsync(EventFeedback eventFeedBack);
    }
}
