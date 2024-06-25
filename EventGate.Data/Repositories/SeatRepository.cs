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

        public async Task<int> AddAsync(Seat seat)
        {
            var existingSeat = await _context.Seats.FirstOrDefaultAsync(s => s.SeatID == seat.SeatID);
            if (existingSeat != null)
            {
                throw new Exception("Seat already exists");
            }

            await _context.Seats.AddAsync(seat);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> UpdateAsync(Seat seat)
        {
            var existingSeat = await _context.Seats.FirstOrDefaultAsync(s => s.SeatID == seat.SeatID);
            if (existingSeat == null)
            {
                throw new Exception("Seat does not exist");
            }

            _context.Seats.Update(seat);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> DeleteAsync(string seatId)
        {
            var seat = await _context.Seats.FirstOrDefaultAsync(s => s.SeatID == seatId);
            if (seat == null)
            {
                throw new Exception("Seat does not exist");
            }

            _context.Seats.Remove(seat);
            return await _context.SaveChangesAsync();
        }

        public async Task<Seat> GetByIdAsync(string seatId)
        {
            var seat = await _context.Seats.FirstOrDefaultAsync(s => s.SeatID == seatId);
            if (seat == null)
            {
                throw new Exception("Seat does not exist");
            }
            return seat;
        }

        public async Task<IEnumerable<Seat>> GetAllAsync()
        {
            return await _context.Seats.ToListAsync();
        }
    }
}
