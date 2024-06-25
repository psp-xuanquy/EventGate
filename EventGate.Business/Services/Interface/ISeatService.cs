using EventGate.Business.Models.DTOs.Request;
using EventGate.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Business.Services.Interface
{
    public interface ISeatService
    {
        Task<ServiceResult<int>> AddAsync(SeatDTO seatDTO);
        Task<ServiceResult<int>> UpdateAsync(SeatDTO seatDTO);
        Task<ServiceResult<int>> DeleteAsync(string seatId);
        Task<ServiceResult<Seat>> GetByIdAsync(string seatId);
        Task<ServiceResult<IEnumerable<Seat>>> GetAllAsync();
    }
}
