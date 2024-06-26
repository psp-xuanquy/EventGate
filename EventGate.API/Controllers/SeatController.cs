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
    public class SeatController : ControllerBase
    {
        private readonly ISeatService _seatService;

        public SeatController(ISeatService seatService)
        {
            _seatService = seatService;
        }

        [HttpGet]
        [SwaggerOperation(Summary = "This API is used to 'Get All Seats'")]
        public async Task<IActionResult> GetAllSeatsAsync()
        {
            try
            {
                var seats = await _seatService.GetAllSeatsAsync();
                return Ok(seats);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{seatId}")]
        [SwaggerOperation(Summary = "This API is used to 'Get Seat by ID'")]
        public async Task<IActionResult> GetSeatByIdAsync(string seatId)
        {
            try
            {
                var seat = await _seatService.GetSeatByIdAsync(seatId);
                if (seat == null)
                {
                    return NotFound();
                }
                return Ok(seat);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [SwaggerOperation(Summary = "This API is used to 'Add Seat'")]
        public async Task<IActionResult> AddSeatAsync([FromBody] SeatDTO seatDto)
        {
            try
            {
                string user = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
                var result = await _seatService.AddSeatAsync(user, seatDto);
                return Ok($"SUCCESS: Seat at Hall '{seatDto.Hall}' and Row '{seatDto.Row}' CREATED successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{seatId}")]
        [SwaggerOperation(Summary = "This API is used to 'Update Seat'")]
        public async Task<IActionResult> UpdateSeatAsync(string seatId, [FromBody] SeatDTO seatDto)
        {
            try
            {
                string user = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
                var result = await _seatService.UpdateSeatAsync(user, seatId, seatDto);
                return Ok($"SUCCESS: Seat with ID '{seatId}' UPDATED successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{seatId}")]
        [SwaggerOperation(Summary = "This API is used to 'Delete Seat'")]
        public async Task<IActionResult> DeleteSeatAsync(string seatId)
        {
            try
            {
                string user = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
                var result = await _seatService.DeleteSeatAsync(user, seatId);
                return Ok($"SUCCESS: Seat with ID '{seatId}' DELETED successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
