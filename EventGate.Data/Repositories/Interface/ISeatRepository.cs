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
        Task<List<Seat>> GetAllAsync();
        Task<Seat> GetByIdAsync(string seatId);
        Task<Seat> GetByHallRowAndNumberAsync(string hall, string row, int number);
        Task<int> AddAsync(string user, Seat addSeat);
        Task<int> UpdateAsync(string user, string seatId, Seat updateSeat);
        Task<int> DeleteAsync(string user, string seatId);
    }
}
