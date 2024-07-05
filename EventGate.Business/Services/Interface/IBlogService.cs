using EventGate.Business.Models.DTOs.Request;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Business.Services.Interface
{
    public interface IBlogService
    {
        Task<IActionResult> GetAllAsync();
        Task<IActionResult> GetAllDeletedAsync();
        Task<IActionResult> GetByIdAsync(string id);
        Task<IActionResult> AddAsync(BlogDTO Blog);
        Task<IActionResult> UpdateAsync(BlogDTO Blog, string id);
        Task<IActionResult> DeleteAsync(string id);
    }
}
