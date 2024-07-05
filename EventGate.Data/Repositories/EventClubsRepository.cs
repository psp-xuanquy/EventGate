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
    public class EventClubsRepository : IEventClubsRepository
    {
        private readonly AppDbContext _appDbContext;

        public EventClubsRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        //Get All Event Club
        public async Task<List<EventClub>> GetAllAsync()
        {
            var list = await _appDbContext.EventClubs
                .Include(ev => ev.Club)
                    .ThenInclude(c => c!.President)
                .Include(ev => ev.Event)
                .ToListAsync();
            return list;
        }

        //Add Event Club
        public async Task<int> AddEventClub(EventClub eventClub)
        {
            _appDbContext.EventClubs.Add(eventClub);
            return await _appDbContext.SaveChangesAsync();
        }

        //Check xem cái event đó có đang tồn tại trong danh sách thời gian đang diễn ra sự kiện của Club đó không? 
        public async Task<EventClub?> CheckDuplicateEventClub(string eventId, string clubId)
        {
            return await _appDbContext.EventClubs
                .FirstOrDefaultAsync(ec => ec.EventID == eventId && ec.ClubID == clubId && ec.DeletedTime == null);
        }

        //Check EventId nay da duoc to chuc boi cau lac bo nao hay chua
        public async Task<EventClub?> GetEventClubByEventIdAsync(string eventId, string clubId)
        {
            return await _appDbContext.EventClubs
                .FirstOrDefaultAsync(ec => ec.EventID == eventId && ec.ClubID != clubId);
        }

        //Get Event Club By Id
        public async Task<EventClub> FindEventClubById(string id)
        {
            var eventclub = await _appDbContext.EventClubs
                .Where(eventclub => eventclub.DeletedTime == null)
                 .Include(eventclub => eventclub.Club)
                 .Include(eventclub => eventclub.Event)
                .FirstOrDefaultAsync(eventclub => eventclub.EventClubID == id);
            return eventclub;
        }

        //Get Event By Club
        public Task<int> FindEventByClub(string idClub)
        {
            throw new NotImplementedException();
        }

        //Update Event Club
        public async Task<int> UpdateAsync(EventClub eventClub)
        {
            _appDbContext.EventClubs.Update(eventClub);
            return await _appDbContext.SaveChangesAsync();
        }

        //Delete Event Club
        public async Task<int> DeleteAsync(EventClub eventClub)
        {   
            eventClub.DeletedTime = DateTime.Now;  
            return await _appDbContext.SaveChangesAsync();
        }

        public async Task<EventClub> FindEventClubByEvent(string idEvent)
        {
            var eventclub = await _appDbContext.EventClubs
                .Where(eventclub => eventclub.DeletedTime == null)
                .Include(eventclub => eventclub.Club)
                .Include(eventclub => eventclub.Event)
                .FirstOrDefaultAsync(eventclub => eventclub.EventID == idEvent);

            return eventclub;
        }
    }
}
