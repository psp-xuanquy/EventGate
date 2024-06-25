using EventGate.Business.Models.DTOs.Request;
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
        Task<ServiceResult<int>> AddAsync(TicketDTO ticketDTO);
        Task<ServiceResult<int>> UpdateAsync(TicketDTO ticketDTO);
        Task<ServiceResult<int>> DeleteAsync(string ticketId);
        Task<ServiceResult<Ticket>> GetByIdAsync(string ticketId);
        Task<ServiceResult<IEnumerable<Ticket>>> GetAllAsync();
    }
}
