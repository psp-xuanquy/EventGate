using EventGate.Data.Entity;
using EventGate.Data.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Data.Repositories
{
    public class SeatRepository : ISeatRepository
    {
        private readonly AppDbContext _context;

        public SeatRepository(AppDbContext context)
        {
            _context = context;
        }

        // Get all Seat
        public async Task<List<Seat>> GetAllAsync()
        {
            return await _context.Seats
                .Where(c => c.DeletedTime == null)
                .OrderBy(s => s.Hall)  
                .ThenBy(s => s.Row)   
                .ThenBy(s => s.Number)
                .ToListAsync();
        }

        // Get Seat by ID
        public async Task<Seat> GetByIdAsync(string seatId)
        {
            return await _context.Seats
                .Where(c => c.DeletedTime == null)
                .FirstOrDefaultAsync(s => s.SeatID == seatId); ;
        }

        // Get Seat by Hall, Row, Number
        public async Task<Seat> GetByHallRowAndNumberAsync(string hall, string row, int number)
        {
            return await _context.Seats
                .Where(s => s.Hall == hall && s.Row == row && s.Number == number && s.DeletedTime == null)
                .FirstOrDefaultAsync();
        }

        // Add Seat
        public async Task<int> AddAsync(string user, Seat addSeat)
        {
            addSeat.CreatedBy = user;
            addSeat.LastUpdatedBy = user;
            addSeat.LastUpdatedTime = DateTime.Now;

            await _context.Seats.AddAsync(addSeat);
            return await _context.SaveChangesAsync();
        }

        // Update Seat
        public async Task<int> UpdateAsync(string user, string seatId, Seat updateSeat)
        {
            var existingSeat = await _context.Seats.FirstOrDefaultAsync(s => s.SeatID == seatId && s.DeletedTime == null);

            existingSeat.Hall = updateSeat.Hall;
            existingSeat.Row = updateSeat.Row;
            existingSeat.Number = updateSeat.Number;
            existingSeat.IsAvailable = updateSeat.IsAvailable;
            existingSeat.LastUpdatedBy = user;
            existingSeat.LastUpdatedTime = DateTime.Now;

            //_context.Seats.Update(updateSeat);
            return await _context.SaveChangesAsync();
        }

        // Delete Seat
        public async Task<int> DeleteAsync(string user, string seatId)
        {
            var seatToDelete = await _context.Seats.FirstOrDefaultAsync(s => s.SeatID == seatId && s.DeletedTime == null);

            seatToDelete.DeletedBy = user;
            seatToDelete.DeletedTime = DateTime.Now;

            return await _context.SaveChangesAsync();
        }
    }
}
