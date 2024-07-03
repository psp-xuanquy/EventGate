using EventGate.Business.Models.DTOs.Request.User;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Business.Services.Interface
{
    public interface IEventFeedBackService
    {
        Task<IActionResult> GetAllAsync();
        Task<IActionResult> GetAllDeletedAsync();
        Task<IActionResult> GetByIdAsync(string id);
        Task<IActionResult> AddAsync(UserEventDTORequest userEvent);
        Task<IActionResult> UpdateAsync(UserEventDTORequest userEvent, string id);
        Task<IActionResult> DeleteAsync(string id);
    }
}
