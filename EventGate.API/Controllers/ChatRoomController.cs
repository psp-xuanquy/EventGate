using EventGate.Business.Models.DTOs.Request.ChatRoom;
using EventGate.Business.Services.Interface;
using EventGate.Data.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;

namespace EventGate.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatRoomController : Controller
    {
        private readonly IChatRoomServices _chatRoomServices;
        public ChatRoomController(IChatRoomServices chatRoomServices)
        {
            this._chatRoomServices = chatRoomServices;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var data = await _chatRoomServices.GetAllAsync();
            return Ok(data);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            var data = await _chatRoomServices.GetByIdAsync(id);
            return Ok(data);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] ChatRoomAddDTO chatRoomDTO)
        {
            var result = await _chatRoomServices.AddChatRoomAsync(chatRoomDTO);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(string id, [FromBody] ChatUppdateDTO chatRoomDTO)
        {
            var result = await _chatRoomServices.UpdateAsync(id, chatRoomDTO);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var result = await _chatRoomServices.DeleteAsync(id);
            return Ok(result);
        }



    }
}
