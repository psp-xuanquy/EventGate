using EventGate.Business.Models.DTOs.Request.User;
using EventGate.Business.Services;
using EventGate.Business.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace EventGate.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserEventController : Controller
    {
        private readonly IUserEventService _userEventService;
        public UserEventController(IUserEventService userEventService)
        {
            _userEventService = userEventService;
        }

        [HttpGet]
        [SwaggerOperation(Summary = "This API is to Get All UserEvent")]
        public async Task<IActionResult> GetAll()
        {
            return await _userEventService.GetAllAsync();
        }

        [HttpGet("/api/UserEvent/Deleted")]
        [SwaggerOperation(Summary = "This API is to Get All UserEvent be Deleted")]
        public async Task<IActionResult> GetAllDeleted()
        {
            return await _userEventService.GetAllDeletedAsync();
        }

        [HttpGet("{id}")]
        [SwaggerOperation(Summary = "This API is to Get UserEvent By Id")]
        public async Task<IActionResult> GetById(string id)
        {
            return await _userEventService.GetByIdAsync(id);
        }

        [HttpPost]
        [SwaggerOperation(Summary = "This API is to Add UserEvent")]
        public async Task<IActionResult> Add([FromBody] UserEventDTORequest userEvent)
        {
            return await _userEventService.AddAsync(userEvent);
        }

        [HttpPut("{id}")]
        [SwaggerOperation(Summary = "This API is to Update UserEvent Through Id")]
        public async Task<IActionResult> Update([FromBody] UserEventDTORequest userEvent, string id)
        {
            return await _userEventService.UpdateAsync(userEvent, id);
        }


        [HttpDelete("{id}")]
        [SwaggerOperation(Summary = "This API is to Delete UserEvent Through Id")]
        public async Task<IActionResult> Delete(string id)
        {
            return await _userEventService.DeleteAsync(id);
        }
    }
}
