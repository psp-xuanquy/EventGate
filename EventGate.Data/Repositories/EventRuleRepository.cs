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
    public class EventRuleRepository : IEventRuleRepository
    {
        private readonly AppDbContext _context;

        public EventRuleRepository(AppDbContext context)
        {
            _context = context;
        }

        // Get All EventRule
        public async Task<List<EventRule>> GetAllAsync()
        {
            return await _context.EventRules
                .Where(c => c.DeletedTime == null)
                .ToListAsync();
        }

        // Get EventRule By ID
        public async Task<EventRule> GetByIdAsync(string eventRuleId)
        {
            return await _context.EventRules
                .Where(c => c.DeletedTime == null)
                .FirstOrDefaultAsync(c => c.RuleID == eventRuleId);
        }

        // Add EventRule 
        public async Task<int> AddAsync(string user, EventRule addEventRule)
        {
            addEventRule.CreatedBy = user;
            addEventRule.LastUpdatedBy = user;
            addEventRule.LastUpdatedTime = DateTime.Now;

            await _context.EventRules.AddAsync(addEventRule);
            return await _context.SaveChangesAsync();
        }

        // Update EventRule
        public async Task<int> UpdateAsync(string user, string eventRuleId, EventRule updateEventRule)
        {
            var existingEventRule = await _context.EventRules.FirstOrDefaultAsync(c => c.RuleID == eventRuleId && c.DeletedTime == null);
            if (existingEventRule != null)
            {
                existingEventRule.RuleDescription = updateEventRule.RuleDescription;
                existingEventRule.EventTypeID = updateEventRule.EventTypeID;
                existingEventRule.LastUpdatedBy = user;
                existingEventRule.LastUpdatedTime = DateTime.Now;

                return await _context.SaveChangesAsync();
            }
            return 0;
        }

        // Delete EventRule
        public async Task<int> DeleteAsync(string user, string eventRuleId)
        {
            var eventRuleToDelete = await _context.EventRules.FirstOrDefaultAsync(c => c.RuleID == eventRuleId && c.DeletedTime == null);
            if (eventRuleToDelete != null)
            {
                eventRuleToDelete.DeletedBy = user;
                eventRuleToDelete.DeletedTime = DateTime.Now;

                return await _context.SaveChangesAsync();
            }
            return 0;
        }
    }
}
