using EventGate.Business.Models.DTOs.Request;
using EventGate.Business.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System;
using System.Threading.Tasks;
using Swashbuckle.AspNetCore.Annotations;

namespace EventGate.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClubController : ControllerBase
    {
        private readonly IClubService _clubService;

        public ClubController(IClubService clubService)
        {
            _clubService = clubService;
        }

        [HttpGet]
        [SwaggerOperation(Summary = "This API is used to 'Get All Clubs'")]
        public async Task<IActionResult> GetAllClubsAsync()
        {
            try
            {
                var clubs = await _clubService.GetAllClubsAsync();
                return Ok(clubs);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{clubId}")]
        [SwaggerOperation(Summary = "This API is used to 'Get Club by ID'")]
        public async Task<IActionResult> GetClubByIdAsync(string clubId)
        {
            try
            {
                var club = await _clubService.GetClubByIdAsync(clubId);
                if (club == null)
                {
                    return NotFound();
                }
                return Ok(club);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [SwaggerOperation(Summary = "This API is used to 'Add Club'")]
        public async Task<IActionResult> AddClubAsync([FromBody] ClubDTO clubDto)
        {
            try
            {
                string user = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
                await _clubService.AddClubAsync(user, clubDto);
                return Ok($"SUCCESS: Club '{clubDto.Name}' CREATED successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{clubId}")]
        [SwaggerOperation(Summary = "This API is used to 'Update Club'")]
        public async Task<IActionResult> UpdateClubAsync(string clubId, [FromBody] ClubDTO clubDto)
        {
            try
            {
                string user = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
                await _clubService.UpdateClubAsync(user, clubId, clubDto);
                return Ok($"SUCCESS: Club with ID ( {clubId} ) UPDATED successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{clubId}")]
        [SwaggerOperation(Summary = "This API is used to 'Delete Club'")]
        public async Task<IActionResult> DeleteClubAsync(string clubId)
        {
            try
            {
                string user = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
                await _clubService.DeleteClubAsync(user, clubId);
                return Ok($"SUCCESS: Club with ID ( {clubId} ) DELETED successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
