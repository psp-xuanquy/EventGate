using EventGate.Business.Models.DTOs.Request;
using EventGate.Data.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Business.Services.Interface
{
    public interface IClubService
    {
        Task<List<ClubDTO>> GetAllClubsAsync();
        Task<ClubDTO> GetClubByIdAsync(string clubId);
        Task<int> AddClubAsync(string user, ClubDTO addClubDto);
        Task<int> UpdateClubAsync(string user, string clubId, ClubDTO updateClubDto);
        Task<int> DeleteClubAsync(string user, string clubId);
    }
}
