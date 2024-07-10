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
    public class TicketRepository : ITicketRepository
    {
        private readonly AppDbContext _context;

        public TicketRepository(AppDbContext context)
        {
            _context = context;
        }

        // Get all Ticket
        public async Task<List<Ticket>> GetAllAsync()
        {
            return await _context.Tickets
                .Where(c => c.DeletedTime == null)
                .ToListAsync();
        }

        // Get Ticket by ID
        public async Task<Ticket> GetByIdAsync(string ticketId)
        {
            return await _context.Tickets
                .Where(c => c.DeletedTime == null)
                .FirstOrDefaultAsync(t => t.TicketID == ticketId);
        }

        // Add Ticket
        public async Task<int> AddAsync(string user, Ticket addTicket)
        {
            addTicket.CreatedBy = user;
            addTicket.LastUpdatedBy = user;
            addTicket.LastUpdatedTime = DateTime.Now;

            await _context.Tickets.AddAsync(addTicket);
            return await _context.SaveChangesAsync();
        }

        // Update Ticket
        public async Task<int> UpdateAsync(string user, string ticketId, Ticket updateTicket)
        {
            var existingTicket = await _context.Tickets.FirstOrDefaultAsync(t => t.TicketID == ticketId && t.DeletedTime == null);
            if (existingTicket != null)
            {
                existingTicket.Gate = updateTicket.Gate;
                existingTicket.QRCode = updateTicket.QRCode;
                existingTicket.Price = updateTicket.Price;
                existingTicket.ExpirationDate = updateTicket.ExpirationDate;
                existingTicket.IsUsed = updateTicket.IsUsed;
                existingTicket.SeatID = updateTicket.SeatID;
                existingTicket.EventID = updateTicket.EventID;
                existingTicket.LastUpdatedBy = user;
                existingTicket.LastUpdatedTime = DateTime.Now;

                return await _context.SaveChangesAsync();
            }
            return 0;
        }

        // Delete Ticket
        public async Task<int> DeleteAsync(string user, string ticketId)
        {
            var ticketToDelete = await _context.Tickets.FirstOrDefaultAsync(t => t.TicketID == ticketId);
            if (ticketToDelete != null)
            {
                ticketToDelete.DeletedBy = user;
                ticketToDelete.DeletedTime = DateTime.Now;

                return await _context.SaveChangesAsync();
            }
            return 0;
        }

        // Check if Seat is associated with another Ticket
        public async Task<bool> IsSeatAssociatedWithAnotherTicketAsync(string seatId)
        {
            return await _context.Tickets.AnyAsync(t => t.SeatID == seatId && t.DeletedTime == null);
        }

        public async Task<Ticket> GetTicketByEventID(string eventId)
        {
            return await _context.Tickets
                .Where(c => c.DeletedTime == null)
                .FirstOrDefaultAsync(t => t.EventID == eventId);
        }
        public async Task<Seat> GetSeatByTicketIdAsync(string ticketId)
        {
            return await _context.Tickets
                .Where(t => t.DeletedTime == null && t.TicketID == ticketId)
                .Select(t => t.Seat) // Select the Seat related to the Ticket
                .FirstOrDefaultAsync();
        }
    }
}
