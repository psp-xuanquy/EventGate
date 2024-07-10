using EventGate.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Data.Repositories.Interface
{
    public interface ITicketRepository
    {
        Task<List<Ticket>> GetAllAsync();
        Task<Ticket> GetByIdAsync(string ticketId);
        Task<int> AddAsync(string user, Ticket addTicket);
        Task<int> UpdateAsync(string user, string ticketId, Ticket updateTicket);
        Task<int> DeleteAsync(string user, string ticketId);
        Task<bool> IsSeatAssociatedWithAnotherTicketAsync(string seatId);
        Task<Ticket> GetTicketByEventID(string eventId);
        Task<Seat> GetSeatByTicketIdAsync(string ticketId);
        Task<Ticket> GetByQrCodeAsync(byte[] qrCode);
    }
}
