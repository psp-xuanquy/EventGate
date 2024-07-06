using EventGate.Business.Models.DTOs.Request;
using EventGate.Business.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace EventGate.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;
        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        [HttpGet]
        [SwaggerOperation(Summary = "This API is to Get All Blog")]
        public async Task<IActionResult> GetAll()
        {
            return await _blogService.GetAllAsync();
        }

        [HttpGet("/api/Blog/Deleted")]
        [SwaggerOperation(Summary = "This API is to Get All Blog be Deleted")]
        public async Task<IActionResult> GetAllDeleted()
        {
            return await _blogService.GetAllDeletedAsync();
        }

        [HttpGet("{id}")]
        [SwaggerOperation(Summary = "This API is to Get Blog By Id")]
        public async Task<IActionResult> GetById(string id)
        {
            return await _blogService.GetByIdAsync(id);
        }

        [HttpPost]
        [SwaggerOperation(Summary = "This API is to Add Blog")]
        public async Task<IActionResult> Add([FromBody] BlogDTO userEvent)
        {
            return await _blogService.AddAsync(userEvent);
        }

        [HttpPut("{id}")]
        [SwaggerOperation(Summary = "This API is to Update Blog Through Id")]
        public async Task<IActionResult> Update([FromBody] BlogDTO userEvent, string id)
        {
            return await _blogService.UpdateAsync(userEvent, id);
        }


        [HttpDelete("{id}")]
        [SwaggerOperation(Summary = "This API is to Delete Blog Through Id")]
        public async Task<IActionResult> Delete(string id)
        {
            return await _blogService.DeleteAsync(id);
        }
    }
}
