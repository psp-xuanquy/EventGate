using EventGate.Business.Models.DTOs.Request.User;
using EventGate.Data.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Business.Services.Interface
{
    public interface IEventClubService
    {
        Task<IActionResult> GetAllAsync();
        Task<IActionResult> AddEventClub(EventClubDTORequest eventclub);
        Task<IActionResult> FindEventByClub(int id);
        Task<IActionResult> UpdateEventClub(string id, EventClubDTORequest eventclub);

        Task<IActionResult> DeleteAsync(string id);
    }
}
