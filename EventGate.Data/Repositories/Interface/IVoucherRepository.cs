using EventGate.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Data.Repositories.Interface
{
    public interface IVoucherRepository
    {
        Task<List<Voucher>> GetAllAsync();
        Task<Voucher> GetByIdAsync(string voucherId);
        Task<Voucher> GetByCodeAsync(string code);
        Task<int> AddAsync(string user, Voucher addVoucher);
        Task<int> UpdateAsync(string user, string voucherId, Voucher updateVoucher);
        Task<int> DeleteAsync(string user, string voucherId);
    }
}
