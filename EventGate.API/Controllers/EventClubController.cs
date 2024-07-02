using EventGate.Business.Models.DTOs.Request.User;
using EventGate.Business.Services;
using EventGate.Business.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace EventGate.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventClubController : ControllerBase
    {
        private readonly IEventClubService _eventClubService;
        public EventClubController(IEventClubService eventClubService)
        {
            _eventClubService = eventClubService;
        }

        [HttpGet]
        [SwaggerOperation(Summary = "This API is to Get All Event Club")]
        public async Task<IActionResult> GetAll()
        {
            return await _eventClubService.GetAllAsync();
        }

        [HttpPost]
        [SwaggerOperation(Summary = "This API is to Add Event Club")]
        public async Task<IActionResult> Add([FromBody] EventClubDTORequest eventClub)
        {
            return await _eventClubService.AddEventClub(eventClub);
        }

        [HttpPut("{id}")]
        [SwaggerOperation(Summary = "This API is to Edit Event Club through id")]
        public async Task<IActionResult> Update([FromBody] EventClubDTORequest eventClub, string id)
        {
            return await _eventClubService.UpdateEventClub(id,eventClub);
        }

        [HttpDelete("{id}")]
        [SwaggerOperation(Summary = "This API is to Edit Status Deleted of EventClub Through Id")]
        public async Task<IActionResult> Delete(string id)
        {
            return await _eventClubService.DeleteAsync(id);
        }
    }
}
