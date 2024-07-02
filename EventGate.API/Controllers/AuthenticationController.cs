﻿using Azure;
using EventGate.Business.Models.DTOs;
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
        private readonly IEmailService _emailService;
        public AuthenticationController(IUserService userService, IEmailService emailService)
        {
            _userService = userService;
            _emailService = emailService;
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> LoginAsync([FromBody] LoginDTO loginDTO)
        {
            try
            {
                var token = await _userService.Login(loginDTO);
                return Ok(new { token.Data });
            }
            catch (UnauthorizedAccessException ex)
            {
                return Unauthorized(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }
        }

        [HttpPost]
        [Route("loginByGoogleMail")]
        public async Task<IActionResult> LoginGoogleAsync([FromBody] LoginDTO loginDTO)
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
                return BadRequest($"Error: {ex.Message}");
            }
        }

        [HttpPost]
        [Route("register/member")]
        [SwaggerOperation(Description = "Example: <br> " +
        "{ <br> \"username\": \"crimson\", <br>" +
        "\"email\": \"dungnxse161720@fpt.edu.vn\", <br>" +
        "\"password\": \"Dung@123\", <br>" +
        "\"confirmedPassword\": \"Dung@123\" <br> }")]
        public async Task<IActionResult> RegisterMember([FromBody] RegisterUserDTO registerMemberDTO)
        {
            try
            {
                await _userService.RegisterByRole(registerMemberDTO, Roles.MEMBER);
                await _emailService.SendConfirmEmailAsync(registerMemberDTO.Email);
                return Ok($"Success: Register Successfully");
            }
            catch (UnauthorizedAccessException ex)
            {
                return Unauthorized(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }
        }

        [HttpPost]
        [Route("register/staff")]
        public async Task<IActionResult> RegisterStaff([FromBody] RegisterUserDTO registerStaffDTO)
        {
            try
            {
                await _userService.RegisterByRole(registerStaffDTO, Roles.STAFF);
                await _emailService.SendConfirmEmailAsync(registerStaffDTO.Email);
                return Ok($"Success: Register Successfully");
            }
            catch (UnauthorizedAccessException ex)
            {
                return Unauthorized(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }
        }

        [HttpPost]
        [Route("register/admin")]
        public async Task<IActionResult> RegisterAdmin([FromBody] RegisterUserDTO registerAdminDTO)
        {
            try
            {
                await _userService.RegisterByRole(registerAdminDTO, Roles.ADMIN);
                return Ok($"Success: Register Successfully");
            }
            catch (UnauthorizedAccessException ex)
            {
                return Unauthorized(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }
        }

        [HttpGet]
        [Route("emailConfirm")]
        public async Task<IActionResult> ConfirmEmail([FromQuery] string id)
        {
            try
            {
                await _userService.ConfirmEmailUser(id);
                return Ok($"Success: Confirm Successfully");
            }
            catch (UnauthorizedAccessException ex)
            {
                return Unauthorized(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }
        }
    }
}
