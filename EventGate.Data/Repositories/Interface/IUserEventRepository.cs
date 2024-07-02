using EventGate.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Data.Repositories.Interface
{
    public interface IUserEventRepository
    {
        Task<List<UserEvent>> GetAllAsync();
        Task<List<UserEvent>> GetAllDeletedAsync();

        Task<int> AddUserEventAsync(UserEvent userEvent);
        Task<UserEvent> GetByIdAsync(string id);
        Task<int> UpdateAsync(UserEvent userEvent);
        Task<int> DeleteAsync(UserEvent userEvent);
    }
}
