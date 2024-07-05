using EventGate.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Data.Repositories.Interface
{
     public interface IUserEventHistoryRepository
    {
        Task<List<UserEventHistory>> GetAllAsync();
        Task<int> AddUserEventHistoryAsync(UserEventHistory eventUserHistory);
    }
}
