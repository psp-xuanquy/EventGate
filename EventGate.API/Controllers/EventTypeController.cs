using EventGate.Business.Models.DTOs.Request;
using EventGate.Business.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Security.Claims;

namespace EventGate.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventTypeController : ControllerBase
    {
        private readonly IEventTypeService _eventTypeService;

        public EventTypeController(IEventTypeService eventTypeService)
        {
            _eventTypeService = eventTypeService;
        }

        [HttpGet]
        [SwaggerOperation(Summary = "This API is used to 'Get All EventTypes'")]
        public async Task<IActionResult> GetAllEventTypesAsync()
        {
            try
            {
                var eventTypes = await _eventTypeService.GetAllEventTypesAsync();
                return Ok(eventTypes);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{eventTypeId}")]
        [SwaggerOperation(Summary = "This API is used to 'Get EventType by ID'")]
        public async Task<IActionResult> GetEventTypeByIdAsync(string eventTypeId)
        {
            try
            {
                var eventType = await _eventTypeService.GetEventTypeByIdAsync(eventTypeId);
                if (eventType == null)
                {
                    return NotFound();
                }
                return Ok(eventType);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [SwaggerOperation(Summary = "This API is used to 'Add EventType'")]
        public async Task<IActionResult> AddEventTypeAsync([FromBody] EventTypeDTO eventTypeDto)
        {
            try
            {
                string user = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
                var result = await _eventTypeService.AddEventTypeAsync(user, eventTypeDto);
                return Ok($"SUCCESS: EventType CREATED successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{eventTypeId}")]
        [SwaggerOperation(Summary = "This API is used to 'Update EventType'")]
        public async Task<IActionResult> UpdateEventTypeAsync(string eventTypeId, [FromBody] EventTypeDTO eventTypeDto)
        {
            try
            {
                string user = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
                var result = await _eventTypeService.UpdateEventTypeAsync(user, eventTypeId, eventTypeDto);
                return Ok($"SUCCESS: EventType with ID '{eventTypeId}' UPDATED successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{eventTypeId}")]
        [SwaggerOperation(Summary = "This API is used to 'Delete EventType'")]
        public async Task<IActionResult> DeleteEventTypeAsync(string eventTypeId)
        {
            try
            {
                string user = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
                var result = await _eventTypeService.DeleteEventTypeAsync(user, eventTypeId);
                return Ok($"SUCCESS: EventType with ID '{eventTypeId}' DELETED successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
