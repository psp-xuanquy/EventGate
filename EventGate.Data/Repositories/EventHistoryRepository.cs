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
    public class EventHistoryRepository : IEventHistoryRepository
    {
        private readonly AppDbContext _appDbContext;

        public EventHistoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<EventHistory>> GetAllAsync()
        {
            var list = await _appDbContext.EventHistories
                .Include(ev => ev.EventType).ToListAsync();
            return list;
        }
        public async Task<int> AddEventHistoryAsync(EventHistory eventHistory)
        {
  
            _appDbContext.EventHistories.Add(eventHistory);
            return await _appDbContext.SaveChangesAsync();
        }
    }
}
