using EventGate.Business.Models.DTOs.Request;
using EventGate.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Business.Services.Interface
{
    public interface IVoucherService
    {
        Task<List<VoucherDTO>> GetAllVouchersAsync();
        Task<VoucherDTO> GetVoucherByIdAsync(string voucherId);
        Task<int> AddVoucherAsync(string user, VoucherDTO addVoucherDto);
        Task<int> UpdateVoucherAsync(string user, string voucherId, VoucherDTO updateVoucherDto);
        Task<int> DeleteVoucherAsync(string user, string voucherId);
    }
}
