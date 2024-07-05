using EventGate.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Data.Repositories.Interface
{
    public interface IEventClubsRepository
    {
        Task<List<EventClub>> GetAllAsync();
        Task<int> AddEventClub(EventClub eventClub);
        Task<int> FindEventByClub(string idClub);
        Task<EventClub> FindEventClubById(string id);
        Task<int> UpdateAsync(EventClub eventClub);
        Task<int> DeleteAsync(EventClub eventClub);
        Task<EventClub> FindEventClubByEvent(string idEvent);
        Task<EventClub> CheckDuplicateEventClub(string eventId, string clubId);
        Task<EventClub> GetEventClubByEventIdAsync(string eventId, string clubId);
    }
}
