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
    public class UserEventRepository : IUserEventRepository
    {

        private readonly AppDbContext _appDbContext;

        public UserEventRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
       

        //Get All UserEvent
        public async Task<List<UserEvent>> GetAllAsync()
        {
            var list = await _appDbContext.UserEvents.Where(x => x.DeletedTime == null)
                .Include(ev => ev.User) 
                .Include(ev => ev.Event).ToListAsync();
            return list;
        }

        //Get All Deleted UserEvent
        public async Task<List<UserEvent>> GetAllDeletedAsync()
        {
            var list = await _appDbContext.UserEvents.Where(x => x.DeletedTime != null)
                 .Include(ev => ev.User)
                 .Include(ev => ev.Event)
                .ToListAsync();
            return list;
        }

        //Get UserEvent By Id
        public async Task<UserEvent> GetByIdAsync(string id)
        {
            var existUserEvent = await _appDbContext.UserEvents
                .Where(user => user.DeletedTime == null)
                .Include(ev => ev.User)
                .Include(ev => ev.Event)
                .FirstOrDefaultAsync(user => user.UserEventID == id);
            return existUserEvent;
        }

        //Add UserEvent
        public async Task<int> AddUserEventAsync(UserEvent userEvent)
        {
            _appDbContext.UserEvents.Add(userEvent);
            return await _appDbContext.SaveChangesAsync();
        }

        //Update UserEvent
        public async Task<int> UpdateAsync(UserEvent userEvent)
        {
            _appDbContext.UserEvents.Update(userEvent);
            return await _appDbContext.SaveChangesAsync();
        }

        //Delete UserEvent
        public async Task<int> DeleteAsync(UserEvent userEvent)
        {
            _appDbContext.UserEvents.Remove(userEvent);
            return await _appDbContext.SaveChangesAsync();
           
        }

       
    }
}
