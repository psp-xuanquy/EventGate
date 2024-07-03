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
    public class EventFeedBackRepository : IEventFeedBackRepository
    {
        private readonly AppDbContext _appDbContext;

        public EventFeedBackRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }


        //Get All EventFeedBack
        public async Task<List<EventFeedback>> GetAllAsync()
        {
            var list = await _appDbContext.EventFeedbacks.Where(x => x.DeletedTime == null)
                .Include(ev => ev.User)
                .Include(ev => ev.Event).ToListAsync();
            return list;
        }

        //Get All Deleted EventFeedBack
        public async Task<List<EventFeedback>> GetAllDeletedAsync()
        {
            var list = await _appDbContext.EventFeedbacks.Where(x => x.DeletedTime != null)
                 .Include(ev => ev.User)
                 .Include(ev => ev.Event)
                .ToListAsync();
            return list;
        }

        //Get EventFeedBack By Id
        public async Task<EventFeedback> GetByIdAsync(string id)
        {
            var existUserEvent = await _appDbContext.EventFeedbacks
                .Where(user => user.DeletedTime == null)
                .Include(ev => ev.User)
                .Include(ev => ev.Event)
                .FirstOrDefaultAsync(user => user.UserID == id);
            return existUserEvent;
        }

        //Add EventFeedBack
        public async Task<int> AddEventFeedBackAsync(EventFeedback userEvent)
        {
            _appDbContext.EventFeedbacks.Add(userEvent);
            return await _appDbContext.SaveChangesAsync();
        }

        //Update EventFeedBack
        public async Task<int> UpdateAsync(EventFeedback userEvent)
        {
            _appDbContext.EventFeedbacks.Update(userEvent);
            return await _appDbContext.SaveChangesAsync();
        }

        //Delete EventFeedBack
        public async Task<int> DeleteAsync(EventFeedback userEvent)
        {
            userEvent.DeletedTime = DateTime.Now;
            return await _appDbContext.SaveChangesAsync();
        }
    }

}
