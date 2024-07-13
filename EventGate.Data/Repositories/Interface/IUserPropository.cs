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
        Task<User> GetByIdAsync(string id);
        Task<int> UpdateAsync(string id, User user);
        Task<int> DeleteAsync(User user);
        Task<User> GetUserByEmail(string email);
        Task<User> VerifyLoginAsync(string username, string password);
        Task<User> VerifyLoginEmailAsync(string userName);
    }
}
