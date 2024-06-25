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
        Task<ServiceResult<int>> AddAsync(VoucherDTO voucherDTO);
        Task<ServiceResult<int>> UpdateAsync(VoucherDTO voucherDTO);
        Task<ServiceResult<int>> DeleteAsync(string voucherId);
        Task<ServiceResult<Voucher>> GetByIdAsync(string voucherId);
        Task<ServiceResult<IEnumerable<Voucher>>> GetAllAsync();
    }
}
