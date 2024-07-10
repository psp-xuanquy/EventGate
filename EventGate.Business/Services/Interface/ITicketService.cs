using EventGate.Business.Models.DTOs.Request;
using EventGate.Business.Models.DTOs.Response;
using EventGate.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Business.Services.Interface
{
    public interface ITicketService
    {
        Task<List<TicketDTO>> GetAllTicketsAsync();
        Task<TicketResponseDTO> GetTicketByIdAsync(string ticketId);
        Task<int> AddTicketAsync(string user, TicketDTO addTicketDto);
        Task<int> UpdateTicketAsync(string user, string ticketId, TicketDTO updateTicketDto);
        Task<int> DeleteTicketAsync(string user, string ticketId);
        Task<bool> CheckinTicketAsync(byte[] qrCode);
    }
}
