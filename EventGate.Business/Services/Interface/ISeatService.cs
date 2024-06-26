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
        Task<List<SeatDTO>> GetAllSeatsAsync();
        Task<SeatDTO> GetSeatByIdAsync(string seatId);
        Task<int> AddSeatAsync(string user, SeatDTO addSeatDto);
        Task<int> UpdateSeatAsync(string user, string seatId, SeatDTO updateSeatDto);
        Task<int> DeleteSeatAsync(string user, string seatId);
    }
}
