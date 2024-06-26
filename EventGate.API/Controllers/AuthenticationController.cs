using EventGate.Business.Models.DTOs.Request;
using EventGate.Business.Services.Interface;
using EventGate.Data.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;


namespace EventGate.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IUserService _userService;
        public AuthenticationController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> LoginAsync([FromBody] LoginDTO loginDTO)
        {
            try
            {
                var token = await _userService.Login(loginDTO);
                return Ok(new { token });
            }
            catch (UnauthorizedAccessException ex)
            {
                return Unauthorized(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error: {ex.Message}");
            }
        }

        [HttpPost]
        [Route("register/member")]
        [SwaggerOperation(Description = "Example: <br> " +
        "{ <br> \"username\": \"crimson\", <br>" +
        "\"email\": \"dung@gmail.com\", <br>" +
        "\"password\": \"Dung@123\", <br>" +
        "\"confirmedPassword\": \"Dung@123\" <br> }")]
        public async Task<IActionResult> RegisterMentor([FromBody] RegisterUserDTO registerMentorDTO)
        {
            try
            {
                return Ok(await _userService.RegisterByRole(registerMentorDTO, Roles.MEMBER));
            }
            catch (UnauthorizedAccessException ex)
            {
                return Unauthorized(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error: {ex.Message}");
            }
        }
    }
}
