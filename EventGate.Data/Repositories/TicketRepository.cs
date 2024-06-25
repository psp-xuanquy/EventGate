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

        public async Task<int> AddAsync(Ticket ticket)
        {
            var existingTicket = await _context.Tickets.FirstOrDefaultAsync(t => t.TicketID == ticket.TicketID);
            if (existingTicket != null)
            {
                throw new Exception("Ticket already exists");
            }

            await _context.Tickets.AddAsync(ticket);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> UpdateAsync(Ticket ticket)
        {
            var existingTicket = await _context.Tickets.FirstOrDefaultAsync(t => t.TicketID == ticket.TicketID);
            if (existingTicket == null)
            {
                throw new Exception("Ticket does not exist");
            }

            _context.Tickets.Update(ticket);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> DeleteAsync(string ticketId)
        {
            var ticket = await _context.Tickets.FirstOrDefaultAsync(t => t.TicketID == ticketId);
            if (ticket == null)
            {
                throw new Exception("Ticket does not exist");
            }

            _context.Tickets.Remove(ticket);
            return await _context.SaveChangesAsync();
        }

        public async Task<Ticket> GetByIdAsync(string ticketId)
        {
            var ticket = await _context.Tickets.FirstOrDefaultAsync(t => t.TicketID == ticketId);
            if (ticket == null)
            {
                throw new Exception("Ticket does not exist");
            }
            return ticket;
        }

        public async Task<IEnumerable<Ticket>> GetAllAsync()
        {
            return await _context.Tickets.ToListAsync();
        }
    }
}
