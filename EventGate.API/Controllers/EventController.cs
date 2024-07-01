using EventGate.Business.Models.DTOs.Request;
using EventGate.Business.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Security.Claims;

namespace EventGate.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        //private readonly IEventService _clubService;

        //public EventController(IEventService clubService)
        //{
        //    _clubService = clubService;
        //}

        //[HttpGet]
        //[SwaggerOperation(Summary = "This API is used to 'Get All Events'")]
        //public async Task<IActionResult> GetAllEventsAsync()
        //{
        //    try
        //    {
        //        var clubs = await _clubService.GetAllEventsAsync();
        //        return Ok(clubs);
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //}

        //[HttpGet("{eventId}")]
        //[SwaggerOperation(Summary = "This API is used to 'Get Event by ID'")]
        //public async Task<IActionResult> GetEventByIdAsync(string clubId)
        //{
        //    try
        //    {
        //        var club = await _clubService.GetEventByIdAsync(clubId);
        //        if (club == null)
        //        {
        //            return NotFound();
        //        }
        //        return Ok(club);
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //}

        //[HttpPost]
        //[SwaggerOperation(Summary = "This API is used to 'Add Event'")]
        //public async Task<IActionResult> AddEventAsync([FromBody] EventDTO eventDto)
        //{
        //    try
        //    {
        //        string user = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
        //        await _clubService.AddEventAsync(user, clubDto);
        //        return Ok($"SUCCESS: Event '{clubDto.Name}' CREATED successfully");
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //}

        //[HttpPut("{clubId}")]
        //[SwaggerOperation(Summary = "This API is used to 'Update Event'")]
        //public async Task<IActionResult> UpdateEventAsync(string clubId, [FromBody] EventDTO clubDto)
        //{
        //    try
        //    {
        //        string user = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
        //        await _clubService.UpdateEventAsync(user, clubId, clubDto);
        //        return Ok($"SUCCESS: Event with ID ( {clubId} ) UPDATED successfully");
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //}

        //[HttpDelete("{clubId}")]
        //[SwaggerOperation(Summary = "This API is used to 'Delete Event'")]
        //public async Task<IActionResult> DeleteEventAsync(string clubId)
        //{
        //    try
        //    {
        //        string user = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
        //        await _clubService.DeleteEventAsync(user, clubId);
        //        return Ok($"SUCCESS: Event with ID ( {clubId} ) DELETED successfully");
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //}
    }
}
