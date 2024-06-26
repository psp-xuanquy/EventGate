using EventGate.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Data.Repositories.Interface
{
    public interface IUserPropository
    {
        Task<List<User>> GetAllAsync();
        Task<List<User>> GetAllDeletedAsync();
        Task<User> GetByIdAsync(string id);
        Task<int> UpdateAsync(string id, User user);
        Task<int> DeleteAsync(string id, User user);
        
        Task<User> VerifyLoginAsync(string username, string password);
    }
}
