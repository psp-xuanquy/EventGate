using EventGate.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Data.Repositories.Interface
{
    public interface IBlogRepository
    {
        Task<List<Blog>> GetAllAsync();
        Task<List<Blog>> GetAllDeletedAsync();

        Task<int> AddEventFeedBackAsync(Blog Blog);
        Task<Blog> GetByIdAsync(string id);
        Task<int> UpdateAsync(Blog Blog);
        Task<int> DeleteAsync(Blog Blog);
    }
}
