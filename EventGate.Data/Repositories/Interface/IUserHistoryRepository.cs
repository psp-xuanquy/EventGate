using EventGate.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Data.Repositories.Interface
{
    public interface IUserHistoryRepository
    {
        Task<List<UserHistory>> GetAllAsync();
        Task<int> AddUserHistoryAsync(UserHistory userHistory);
    }
}
