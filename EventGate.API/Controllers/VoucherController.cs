using EventGate.Business.Models.DTOs.Request;
using EventGate.Business.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
        public async Task<IActionResult> GetAllVouchers()
        {
            var result = await _voucherService.GetAllAsync();

            if (result.IsSuccess)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        [HttpGet("{voucherId}")]
        public async Task<IActionResult> GetVoucherById(string voucherId)
        {
            var result = await _voucherService.GetByIdAsync(voucherId);

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
        public async Task<IActionResult> AddVoucher([FromBody] VoucherDTO voucherDTO)
        {
            var result = await _voucherService.AddAsync(voucherDTO);

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
        public async Task<IActionResult> UpdateVoucher([FromBody] VoucherDTO voucherDTO)
        {
            var result = await _voucherService.UpdateAsync(voucherDTO);

            if (result.IsSuccess)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        [HttpDelete("{voucherId}")]
        public async Task<IActionResult> DeleteVoucher(string voucherId)
        {
            var result = await _voucherService.DeleteAsync(voucherId);

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
