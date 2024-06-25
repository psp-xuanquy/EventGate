using EventGate.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Data.Repositories.Interface
{
    public interface ISeatRepository
    {
        Task<int> AddAsync(Seat seat);
        Task<int> UpdateAsync(Seat seat);
        Task<int> DeleteAsync(string seatId);
        Task<Seat> GetByIdAsync(string seatId);
        Task<IEnumerable<Seat>> GetAllAsync();
    }
}
