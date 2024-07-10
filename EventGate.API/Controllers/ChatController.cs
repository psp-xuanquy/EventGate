using EventGate.Business.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EventGate.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatController : ControllerBase
    {

        private readonly IChatService _chatServices;
        public ChatController(IChatService chatService)
        {
            this._chatServices = chatService;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAll(string id)
        {
            var data = await _chatServices.GetAllAsync(id);
            return Ok(data);
        }
    }
}
