using EventGate.Business.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace EventGate.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventHistoryController : Controller
    {
        private readonly IEventHistoryService _eventHistoryService;

        public EventHistoryController(IEventHistoryService eventHistoryService)
        {
            _eventHistoryService = eventHistoryService;
        }


        [HttpGet]
        [SwaggerOperation(Summary = "This API is to Get All UserHistory")]
        public async Task<IActionResult> GetAll()
        {
            return await _eventHistoryService.GetAllAsync();
        }
    }
}
