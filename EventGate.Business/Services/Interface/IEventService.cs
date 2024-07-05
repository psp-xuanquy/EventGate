using EventGate.Business.Models.DTOs.Request;
using EventGate.Business.Models.DTOs.Response.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Business.Services.Interface
{
    public interface IEventService
    {
        Task<List<EventDTOResponse>> GetAllEventsAsync();
        Task<EventDTOResponse> GetEventByIdAsync(string eventId);
        Task<int> AddEventAsync(string user, EventDTO addEventDto);
        Task<int> UpdateEventAsync(string user, string eventId, EventDTO updateEventDto);
        Task<int> DeleteEventAsync(string user, string eventId);
    }
}
