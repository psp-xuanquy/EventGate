using EventGate.Business.Models.DTOs.Request;
using EventGate.Business.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
        public async Task<IActionResult> GetAllTickets()
        {
            var result = await _ticketService.GetAllAsync();

            if (result.IsSuccess)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        [HttpGet("{ticketId}")]
        public async Task<IActionResult> GetTicketById(string ticketId)
        {
            var result = await _ticketService.GetByIdAsync(ticketId);

            if (result.IsSuccess)
            {
                return Ok(result);
            }
            else
            {
                return NotFound(result);
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddTicket([FromBody] TicketDTO ticketDTO)
        {
            var result = await _ticketService.AddAsync(ticketDTO);

            if (result.IsSuccess)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateTicket([FromBody] TicketDTO ticketDTO)
        {
            var result = await _ticketService.UpdateAsync(ticketDTO);

            if (result.IsSuccess)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        [HttpDelete("{ticketId}")]
        public async Task<IActionResult> DeleteTicket(string ticketId)
        {
            var result = await _ticketService.DeleteAsync(ticketId);

            if (result.IsSuccess)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }
    }
}
