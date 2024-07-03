using EventGate.Business.Models.DTOs.Request.User;
using EventGate.Business.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace EventGate.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventFeedbackController : Controller
    {
        private readonly IEventFeedBackService _eventFeedBackService;
        public EventFeedbackController(IEventFeedBackService userEventService)
        {
            _eventFeedBackService = userEventService;
        }

        [HttpGet]
        [SwaggerOperation(Summary = "This API is to Get All UserFeedBack")]
        public async Task<IActionResult> GetAll()
        {
            return await _eventFeedBackService.GetAllAsync();
        }

        [HttpGet("/api/UserFeedBack/Deleted")]
        [SwaggerOperation(Summary = "This API is to Get All UserFeedBack be Deleted")]
        public async Task<IActionResult> GetAllDeleted()
        {
            return await _eventFeedBackService.GetAllDeletedAsync();
        }

        [HttpGet("{id}")]
        [SwaggerOperation(Summary = "This API is to Get UserFeedBack By Id")]
        public async Task<IActionResult> GetById(string id)
        {
            return await _eventFeedBackService.GetByIdAsync(id);
        }

        [HttpPost]
        [SwaggerOperation(Summary = "This API is to Add UserFeedBack")]
        public async Task<IActionResult> Add([FromBody] UserEventDTORequest userEvent)
        {
            return await _eventFeedBackService.AddAsync(userEvent);
        }

        [HttpPut("{id}")]
        [SwaggerOperation(Summary = "This API is to Update UserFeedBack Through Id")]
        public async Task<IActionResult> Update([FromBody] UserEventDTORequest userEvent, string id)
        {
            return await _eventFeedBackService.UpdateAsync(userEvent, id);
        }


        [HttpDelete("{id}")]
        [SwaggerOperation(Summary = "This API is to Delete UserFeedBack Through Id")]
        public async Task<IActionResult> Delete(string id)
        {
            return await _eventFeedBackService.DeleteAsync(id);
        }
    }
}
