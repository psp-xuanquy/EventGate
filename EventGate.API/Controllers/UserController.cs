using EventGate.Business.Models.DTOs.Request.User;
using EventGate.Business.Services.Interface;

using EventGate.Data.Entity;
using EventGate.Data.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace EventGate.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            this._userService = userService;
        }

        [HttpGet]
        [SwaggerOperation(Summary = "This API is to Get All User")]
        public async Task<IActionResult> GetAll()
        {
            return await _userService.GetAllAsync();
        }

        [HttpGet("/api/User/Deleted")]
        [SwaggerOperation(Summary = "This API is to Get All User be Deleted")]
        public async Task<IActionResult> GetAllDeleted()
        {
            return await _userService.GetAllDeletedAsync();
        }

        [HttpGet("{id}")]
        [SwaggerOperation(Summary = "This API is to Get User By Id")]
        public async Task<IActionResult> GetById(string id)
        {
            return await _userService.GetByIdAsync(id);
        }


        [HttpPut("{id}")]
        [SwaggerOperation(Summary = "This API is to Update User Through Id")]
        public async Task<IActionResult> Update([FromBody] UpdateUserDTORequest user, string id)
        {
            return await _userService.UpdateAsync(user, id);
        }


        [HttpDelete("{id}")]
        [SwaggerOperation(Summary = "This API is to Delete User Through Id")]
        public async Task<IActionResult> Delete(string id)
        {
            return await _userService.DeleteAsync(id);   
        }
    }
}
