using EventGate.Business.Models.DTOs.Request;
using EventGate.Business.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EventGate.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeatController : ControllerBase
    {
        private readonly ISeatService _seatService;

        public SeatController(ISeatService seatService)
        {
            _seatService = seatService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllSeats()
        {
            var result = await _seatService.GetAllAsync();

            if (result.IsSuccess)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        [HttpGet("{seatId}")]
        public async Task<IActionResult> GetSeatById(string seatId)
        {
            var result = await _seatService.GetByIdAsync(seatId);

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
        public async Task<IActionResult> AddSeat([FromBody] SeatDTO seatDTO)
        {
            var result = await _seatService.AddAsync(seatDTO);

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
        public async Task<IActionResult> UpdateSeat([FromBody] SeatDTO seatDTO)
        {
            var result = await _seatService.UpdateAsync(seatDTO);

            if (result.IsSuccess)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        [HttpDelete("{seatId}")]
        public async Task<IActionResult> DeleteSeat(string seatId)
        {
            var result = await _seatService.DeleteAsync(seatId);

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
