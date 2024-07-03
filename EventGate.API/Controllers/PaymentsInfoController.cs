
using EventGate.Business.Models.DTOs.Request;
using EventGate.Business.Services;
using EventGate.Business.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Security.Claims;

namespace PaymentsInfoGate.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentsInfoController : ControllerBase
    {
        private readonly IPaymentsInfoService _paymentsInfoService;

        public PaymentsInfoController(IPaymentsInfoService paymentsInfoService)
        {
            _paymentsInfoService = paymentsInfoService;
        }

        [HttpGet]
        [SwaggerOperation(Summary = "This API is used to 'Get All PaymentsInfo")]
        public async Task<IActionResult> GetAllPaymentsInfosAsync()
        {
            try
            {
                var paymentsInfos = await _paymentsInfoService.GetAllPaymentsInfosAsync();
                return Ok(paymentsInfos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{paymentsInfoId}")]
        [SwaggerOperation(Summary = "This API is used to 'Get PaymentsInfo by ID'")]
        public async Task<IActionResult> GetPaymentsInfoByIdAsync(string paymentsInfoId)
        {
            try
            {
                var paymentsInfo = await _paymentsInfoService.GetPaymentsInfoByIdAsync(paymentsInfoId);
                if (paymentsInfo == null)
                {
                    return NotFound();
                }
                return Ok(paymentsInfo);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [SwaggerOperation(Summary = "This API is used to 'Add PaymentsInfo'")]
        public async Task<IActionResult> AddPaymentsInfoAsync([FromBody] PaymentsInfoDTO paymentsInfoDto)
        {
            try
            {
                string user = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
                await _paymentsInfoService.AddPaymentsInfoAsync(user, paymentsInfoDto);
                return Ok($"SUCCESS: PaymentsInfo CREATED successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{paymentsInfoId}")]
        [SwaggerOperation(Summary = "This API is used to 'Update PaymentsInfo'")]
        public async Task<IActionResult> UpdatePaymentsInfoAsync(string paymentsInfoId, [FromBody] PaymentsInfoDTO paymentsInfoDto)
        {
            try
            {
                string user = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
                await _paymentsInfoService.UpdatePaymentsInfoAsync(user, paymentsInfoId, paymentsInfoDto);
                return Ok($"SUCCESS: PaymentsInfo with ID ( {paymentsInfoId} ) UPDATED successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{paymentsInfoId}")]
        [SwaggerOperation(Summary = "This API is used to 'Delete PaymentsInfo'")]
        public async Task<IActionResult> DeletePaymentsInfoAsync(string paymentsInfoId)
        {
            try
            {
                string user = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
                await _paymentsInfoService.DeletePaymentsInfoAsync(user, paymentsInfoId);
                return Ok($"SUCCESS: PaymentsInfo with ID ( {paymentsInfoId} ) DELETED successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
