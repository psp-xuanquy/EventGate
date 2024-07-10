using EventGate.Business.Models.DTOs.Request;
using EventGate.Business.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Security.Claims;

namespace EventGate.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly ITicketService _ticketService;

        public TicketController(ITicketService ticketService)
        {
            _ticketService = ticketService;
        }

        [HttpGet]
        [SwaggerOperation(Summary = "This API is used to 'Get All Tickets'")]
        public async Task<IActionResult> GetAllTicketsAsync()
        {
            try
            {
                var tickets = await _ticketService.GetAllTicketsAsync();
                return Ok(tickets);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{ticketId}")]
        [SwaggerOperation(Summary = "This API is used to 'Get Ticket By ID'")]
        public async Task<IActionResult> GetTicketByIdAsync(string ticketId)
        {
            try
            {
                var ticket = await _ticketService.GetTicketByIdAsync(ticketId);
                if (ticket == null)
                {
                    return NotFound();
                }
                return Ok(ticket);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [SwaggerOperation(Summary = "This API is used to 'Add Ticket'")]
        public async Task<IActionResult> AddTicketAsync([FromBody] TicketDTO ticketDto)
        {
            try
            {
                string user = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
                var result = await _ticketService.AddTicketAsync(user, ticketDto);
                return Ok("SUCCESS: Ticket CREATED successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{ticketId}")]
        [SwaggerOperation(Summary = "This API is used to 'Update Ticket'")]
        public async Task<IActionResult> UpdateTicketAsync(string ticketId, [FromBody] TicketDTO ticketDto)
        {
            try
            {
                //string user = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
                var result = await _ticketService.UpdateTicketAsync( ticketId, ticketDto);
                return Ok($"SUCCESS: Ticket with ID '{ticketId}' UPDATED successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut("{ticketId}/QRcode")]
        [SwaggerOperation(Summary = "This API is used to 'Update Ticket'")]
        public async Task<IActionResult> UpdateQRTicketAsync(string ticketId, string ?QRCOde)
        {
            try
            {
                //string user = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
                var result = await _ticketService.UpdateQRCodeTicketAsync( ticketId, QRCOde);
                return Ok($"SUCCESS: Ticket with ID '{ticketId}' UPDATED successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpDelete("{ticketId}")]
        [SwaggerOperation(Summary = "This API is used to 'Delete Ticket'")]
        public async Task<IActionResult> DeleteTicketAsync(string ticketId)
        {
            try
            {
                string user = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
                var result = await _ticketService.DeleteTicketAsync(user, ticketId);
                return Ok($"SUCCESS: Ticket with ID '{ticketId}' DELETED successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
