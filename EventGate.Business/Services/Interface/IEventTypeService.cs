using EventGate.Business.Models.DTOs.Request;
using EventGate.Business.Models.DTOs.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Business.Services.Interface
{
    public interface IEventTypeService
    {
        Task<List<EventTypeDTOResponse>> GetAllEventTypesAsync();
        Task<EventTypeDTOResponse> GetEventTypeByIdAsync(string eventTypeId);
        Task<int> AddEventTypeAsync(string user, EventTypeDTO addEventTypeDto);
        Task<int> UpdateEventTypeAsync(string user, string eventTypeId, EventTypeDTO updateEventTypeDto);
        Task<int> DeleteEventTypeAsync(string user, string eventTypeId);
    }
}
