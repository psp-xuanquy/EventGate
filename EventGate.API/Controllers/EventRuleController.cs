using EventGate.Business.Models.DTOs.Request;
using EventGate.Business.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Security.Claims;

namespace EventGate.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventRuleController : ControllerBase
    {
        private readonly IEventRuleService _eventRuleService;

        public EventRuleController(IEventRuleService eventRuleService)
        {
            _eventRuleService = eventRuleService;
        }

        [HttpGet]
        [SwaggerOperation(Summary = "This API is used to 'Get All EventRules'")]
        public async Task<IActionResult> GetAllEventRulesAsync()
        {
            try
            {
                var eventRules = await _eventRuleService.GetAllEventRulesAsync();
                return Ok(eventRules);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{eventRuleId}")]
        [SwaggerOperation(Summary = "This API is used to 'Get EventRule by ID'")]
        public async Task<IActionResult> GetEventRuleByIdAsync(string eventRuleId)
        {
            try
            {
                var eventRule = await _eventRuleService.GetEventRuleByIdAsync(eventRuleId);
                if (eventRule == null)
                {
                    return NotFound();
                }
                return Ok(eventRule);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [SwaggerOperation(Summary = "This API is used to 'Add EventRule'")]
        public async Task<IActionResult> AddEventRuleAsync([FromBody] EventRuleDTO eventRuleDto)
        {
            try
            {
                string user = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
                await _eventRuleService.AddEventRuleAsync(user, eventRuleDto);
                return Ok($"SUCCESS: EventRule '{eventRuleDto.EventTypeID}' CREATED successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{eventRuleId}")]
        [SwaggerOperation(Summary = "This API is used to 'Update EventRule'")]
        public async Task<IActionResult> UpdateEventRuleAsync(string eventRuleId, [FromBody] EventRuleDTO eventRuleDto)
        {
            try
            {
                string user = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
                await _eventRuleService.UpdateEventRuleAsync(user, eventRuleId, eventRuleDto);
                return Ok($"SUCCESS: EventRule with ID ( {eventRuleId} ) UPDATED successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{eventRuleId}")]
        [SwaggerOperation(Summary = "This API is used to 'Delete EventRule'")]
        public async Task<IActionResult> DeleteEventRuleAsync(string eventRuleId)
        {
            try
            {
                string user = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
                await _eventRuleService.DeleteEventRuleAsync(user, eventRuleId);
                return Ok($"SUCCESS: EventRule with ID ( {eventRuleId} ) DELETED successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
