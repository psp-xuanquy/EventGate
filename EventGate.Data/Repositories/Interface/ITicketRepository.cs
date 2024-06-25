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
        Task<int> AddAsync(Ticket ticket);
        Task<int> UpdateAsync(Ticket ticket);
        Task<int> DeleteAsync(string ticketId);
        Task<Ticket> GetByIdAsync(string ticketId);
        Task<IEnumerable<Ticket>> GetAllAsync();
    }
}
