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
    public class EventTypeRepository : IEventTypeRepository
    {
        private readonly AppDbContext _context;

        public EventTypeRepository(AppDbContext context)
        {
            _context = context;
        }

        // Get all EventType
        public async Task<List<EventType>> GetAllAsync()
        {
            return await _context.EventTypes
                .Where(c => c.DeletedTime == null)
                .ToListAsync();
        }

        // Get EventType by ID
        public async Task<EventType> GetByIdAsync(string eventTypeId)
        {
            return await _context.EventTypes
                .Where(c => c.DeletedTime == null)
                .FirstOrDefaultAsync(s => s.EventTypeID == eventTypeId); ;
        }

        public async Task<EventType> GetByNameAsync(string eventTypeName)
        {
            return await _context.EventTypes
                .Where(c => c.DeletedTime == null)
                .FirstOrDefaultAsync(s => s.EventTypeName == eventTypeName); ;
        }

        // Add EventType
        public async Task<int> AddAsync(string user, EventType addEventType)
        {
            addEventType.CreatedBy = user;
            addEventType.LastUpdatedBy = user;
            addEventType.LastUpdatedTime = DateTime.Now;

            await _context.EventTypes.AddAsync(addEventType);
            return await _context.SaveChangesAsync();
        }

        // Update EventType
        public async Task<int> UpdateAsync(string user, string eventTypeId, EventType updateEventType)
        {
            var existingEventType = await _context.EventTypes.FirstOrDefaultAsync(s => s.EventTypeID == eventTypeId && s.DeletedTime == null);
            if (existingEventType != null)
            {
                existingEventType.EventTypeName = updateEventType.EventTypeName;
                existingEventType.LastUpdatedBy = user;
                existingEventType.LastUpdatedTime = DateTime.Now;

                return await _context.SaveChangesAsync();
            }
            return 0;
        }

        // Delete EventType
        public async Task<int> DeleteAsync(string user, string eventTypeId)
        {
            var eventTypeToDelete = await _context.EventTypes.FirstOrDefaultAsync(s => s.EventTypeID == eventTypeId && s.DeletedTime == null);
            if (eventTypeToDelete != null)
            {
                eventTypeToDelete.DeletedBy = user;
                eventTypeToDelete.DeletedTime = DateTime.Now;

                return await _context.SaveChangesAsync();
            }
            return 0;
        }
    }
}
