using EventGate.Business.Models.DTOs.Request;
using EventGate.Business.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Security.Claims;

namespace EventGate.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VoucherController : ControllerBase
    {
        private readonly IVoucherService _voucherService;

        public VoucherController(IVoucherService voucherService)
        {
            _voucherService = voucherService;
        }

        [HttpGet]
        [SwaggerOperation(Summary = "This API is used to 'Get all Vouchers'")]
        public async Task<IActionResult> GetAllVouchersAsync()
        {
            try
            {
                var vouchers = await _voucherService.GetAllVouchersAsync();
                return Ok(vouchers);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{voucherId}")]
        [SwaggerOperation(Summary = "This API is used to 'Get Voucher by ID'")]
        public async Task<IActionResult> GetVoucherByIdAsync(string voucherId)
        {
            try
            {
                var voucher = await _voucherService.GetVoucherByIdAsync(voucherId);
                if (voucher == null)
                {
                    return NotFound();
                }
                return Ok(voucher);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [SwaggerOperation(Summary = "This API is used to 'Add Voucher'")]
        public async Task<IActionResult> AddVoucherAsync([FromBody] VoucherDTO voucherDto)
        {
            try
            {
                string user = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
                var result = await _voucherService.AddVoucherAsync(user, voucherDto);
                return Ok($"SUCCESS: Voucher with code '{voucherDto.Code}' ADDED successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{voucherId}")]
        [SwaggerOperation(Summary = "This API is used to 'Update Voucher'")]
        public async Task<IActionResult> UpdateVoucherAsync(string voucherId, [FromBody] VoucherDTO voucherDto)
        {
            try
            {
                string user = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
                var result = await _voucherService.UpdateVoucherAsync(user, voucherId, voucherDto);
                return Ok($"SUCCESS: Voucher with ID '{voucherId}' UPDATED successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{voucherId}")]
        [SwaggerOperation(Summary = "This API is used to 'Delete Voucher'")]
        public async Task<IActionResult> DeleteVoucherAsync(string voucherId)
        {
            try
            {
                string user = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
                var result = await _voucherService.DeleteVoucherAsync(user, voucherId);
                return Ok($"SUCCESS: Voucher with ID '{voucherId}' DELETED successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
