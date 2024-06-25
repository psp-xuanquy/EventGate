using EventGate.Business.Models.DTOs.Request;
using EventGate.Business.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EventGate.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailController : ControllerBase
    {
        private readonly IOrderDetailService _orderDetailService;

        public OrderDetailController(IOrderDetailService orderDetailService)
        {
            _orderDetailService = orderDetailService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllOrderDetails()
        {
            var result = await _orderDetailService.GetAllAsync();

            if (result.IsSuccess)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        [HttpGet("{orderDetailId}")]
        public async Task<IActionResult> GetOrderDetailById(string orderDetailId)
        {
            var result = await _orderDetailService.GetByIdAsync(orderDetailId);

            if (result.IsSuccess)
            {
                return Ok(result);
            }
            else
            {
                return NotFound(result);
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddOrderDetail([FromBody] OrderDetailDTO orderDetailDTO)
        {
            var result = await _orderDetailService.AddAsync(orderDetailDTO);

            if (result.IsSuccess)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateOrderDetail([FromBody] OrderDetailDTO orderDetailDTO)
        {
            var result = await _orderDetailService.UpdateAsync(orderDetailDTO);

            if (result.IsSuccess)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        [HttpDelete("{orderDetailId}")]
        public async Task<IActionResult> DeleteOrderDetail(string orderDetailId)
        {
            var result = await _orderDetailService.DeleteAsync(orderDetailId);

            if (result.IsSuccess)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }
    }
}
