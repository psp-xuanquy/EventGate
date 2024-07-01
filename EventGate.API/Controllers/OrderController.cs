using EventGate.Business.Models.DTOs.Request;
using EventGate.Business.Models.DTOs.Request.Order;
using EventGate.Business.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Security.Claims;

namespace EventGate.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet]
        [SwaggerOperation(Summary = "This API is used to 'Get All Orders'")]
        public async Task<IActionResult> GetAllOrdersAsync()
        {
            try
            {
                var orders = await _orderService.GetAllOrdersAsync();
                return Ok(orders);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{orderId}")]
        [SwaggerOperation(Summary = "This API is used to 'Get Order By ID'")]
        public async Task<IActionResult> GetOrderByIdAsync(string orderId)
        {
            try
            {
                var order = await _orderService.GetOrderByIdAsync(orderId);
                if (order == null)
                {
                    return NotFound();
                }
                return Ok(order);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [SwaggerOperation(Summary = "This API is used to 'Add Order'")]
        public async Task<IActionResult> AddOrderAsync([FromBody] AddOrderDTO orderDto)
        {
            try
            {
                var user = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
                var result = await _orderService.AddOrderAsync(user, orderDto);
                return Ok($"SUCCESS: Order CREATED successfully");

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{orderId}")]
        [SwaggerOperation(Summary = "This API is used to 'Update Order'")]
        public async Task<IActionResult> UpdateOrderAsync(string orderId, [FromBody] UpdateOrderDTO orderDto)
        {
            try
            {
                var user = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
                var result = await _orderService.UpdateOrderAsync(user, orderId, orderDto);
                return Ok($"SUCCESS: Order with ID ( {orderId} ) UPDATED successfully");

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{orderId}")]
        [SwaggerOperation(Summary = "This API is used to 'Delete Order'")]
        public async Task<IActionResult> DeleteOrderAsync(string orderId)
        {
            try
            {
                var user = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
                var result = await _orderService.DeleteOrderAsync(user, orderId);
                return Ok($"SUCCESS: Order with ID ( {orderId} ) DELETED successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
