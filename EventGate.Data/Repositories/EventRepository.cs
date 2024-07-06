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
    public class EventRepository : IEventRepository
    {
        private readonly AppDbContext _context;

        public EventRepository(AppDbContext context)
        {
            _context = context;
        }

        // Get All Event
        public async Task<List<Event>> GetAllAsync()
        {
            return await _context.Events
                .Include(e => e.EventType)
                .Include(e => e.EventClubs)
                    .ThenInclude(ec => ec.Club)
                        .ThenInclude(c => c.President)
                .Include(e => e.Tickets)
                .Where(e => e.DeletedTime == null)
                .ToListAsync();
        }

        // Get Event By ID
        public async Task<Event> GetByIdAsync(string eventId)
        {
            return await _context.Events
                .Include(e => e.EventType)
                .Include(e => e.EventClubs)
                    .ThenInclude(ec => ec.Club)
                        .ThenInclude(c => c.President)
                .Include(e => e.Tickets)
                .Where(e => e.DeletedTime == null && e.EventID == eventId)
                .FirstOrDefaultAsync();
        }

        // Get All Tickets by EventID
        public async Task<List<Ticket>> GetTicketsByEventIdAsync(string eventId)
        {
            return await _context.Tickets
                .Where(t => t.EventID == eventId && t.DeletedTime == null)
                .ToListAsync();
        }

        // Add Event 
        public async Task<int> AddAsync(string user, Event addEvent)
        {
            addEvent.CreatedBy = user;
            addEvent.LastUpdatedBy = user;
            addEvent.LastUpdatedTime = DateTime.Now;

            await _context.Events.AddAsync(addEvent);
            return await _context.SaveChangesAsync();
        }

        // Update Event
        public async Task<int> UpdateAsync(string user, string eventId, Event updateEvent)
        {
            var existingEvent = await _context.Events.FirstOrDefaultAsync(c => c.EventID == eventId && c.DeletedTime == null);
            if (existingEvent != null)
            {
                existingEvent.EventName = updateEvent.EventName;
                existingEvent.Location = updateEvent.Location;
                existingEvent.Content = updateEvent.Content;
                existingEvent.LinkStream = updateEvent.LinkStream;
                existingEvent.StartDate = updateEvent.StartDate;
                existingEvent.EndDate = updateEvent.EndDate;
                existingEvent.Status = updateEvent.Status;
                existingEvent.TicketQuantity = updateEvent.TicketQuantity;
                existingEvent.PosterImage = updateEvent.PosterImage;
                existingEvent.QRCode = updateEvent.QRCode;
                existingEvent.Price = updateEvent.Price;
                existingEvent.IsDeleted = updateEvent.IsDeleted;

                existingEvent.LastUpdatedBy = user;
                existingEvent.LastUpdatedTime = DateTime.Now;

                return await _context.SaveChangesAsync();
            }
            return 0;
        }

        // Delete Event
        public async Task<int> DeleteAsync(string user, string eventId)
        {
            var eventToDelete = await _context.Events.FirstOrDefaultAsync(c => c.EventID == eventId && c.DeletedTime == null);
            _context.Events.Remove(eventToDelete);
            return await _context.SaveChangesAsync();
        }
    }
}
