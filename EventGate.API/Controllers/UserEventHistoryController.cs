using EventGate.Business.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace EventGate.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserEventHistoryController : Controller
    {
        private readonly IUserEventHistoryService _userEventHistoryService;

        public UserEventHistoryController(IUserEventHistoryService userEventHistoryService)
        {
            _userEventHistoryService = userEventHistoryService;
        }


        [HttpGet]
        [SwaggerOperation(Summary = "This API is to Get All UserEventHistory")]
        public async Task<IActionResult> GetAll()
        {
            return await _userEventHistoryService.GetAllAsync();
        }
    }
}
