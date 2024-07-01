using EventGate.Business.Models.DTOs.Request;
using EventGate.Business.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

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

        [HttpGet("{orderDetailId}")]
        [SwaggerOperation(Summary = "This API is used to 'Get OrderDetail By ID'")]
        public async Task<IActionResult> GetOrderDetailByIdAsync(string orderDetailId)
        {
            try
            {
                var orderDetail = await _orderDetailService.GetOrderDetailByIdAsync(orderDetailId);
                if (orderDetail == null)
                {
                    return NotFound();
                }
                return Ok(orderDetail);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("byOrder/{orderId}")]
        [SwaggerOperation(Summary = "This API is used to 'Get OrderDetails By OrderID'")]
        public async Task<IActionResult> GetOrderDetailsByOrderIdAsync(string orderId)
        {
            try
            {
                var orderDetails = await _orderDetailService.GetOrderDetailsByOrderIdAsync(orderId);
                return Ok(orderDetails);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
