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
        private readonly IEventService _eventService;

        public EventController(IEventService eventService)
        {
            _eventService = eventService;
        }

        [HttpGet]
        [SwaggerOperation(Summary = "This API is used to 'Get All Events'")]
        public async Task<IActionResult> GetAllEventsAsync()
        {
            try
            {
                var events = await _eventService.GetAllEventsAsync();
                return Ok(events);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{eventId}")]
        [SwaggerOperation(Summary = "This API is used to 'Get Event by ID'")]
        public async Task<IActionResult> GetEventByIdAsync(string eventId)
        {
            try
            {
                var eventA = await _eventService.GetEventByIdAsync(eventId);
                if (eventA == null)
                {
                    return NotFound();
                }
                return Ok(eventA);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{eventId}/tickets")]
        [SwaggerOperation(Summary = "This API is used to 'Get All Tickets by Event ID'")]
        public async Task<IActionResult> GetTicketsByEventIdAsync(string eventId)
        {
            try
            {
                var tickets = await _eventService.GetTicketsByEventIdAsync(eventId);
                return Ok(tickets);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [SwaggerOperation(Summary = "This API is used to 'Add Event'")]
        public async Task<IActionResult> AddEventAsync([FromBody] EventDTO eventDto)
        {
            try
            {
                string user = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
                await _eventService.AddEventAsync(user, eventDto);
                return Ok($"SUCCESS: Event '{eventDto.EventTypeID}' CREATED successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{eventId}")]
        [SwaggerOperation(Summary = "This API is used to 'Update Event'")]
        public async Task<IActionResult> UpdateEventAsync(string eventId, [FromBody] EventDTO eventDto)
        {
            try
            {
                string user = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
                await _eventService.UpdateEventAsync(user, eventId, eventDto);
                return Ok($"SUCCESS: Event with ID ( {eventId} ) UPDATED successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{eventId}")]
        [SwaggerOperation(Summary = "This API is used to 'Delete Event'")]
        public async Task<IActionResult> DeleteEventAsync(string eventId)
        {
            try
            {
                string user = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
                await _eventService.DeleteEventAsync(user, eventId);
                return Ok($"SUCCESS: Event with ID ( {eventId} ) DELETED successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
