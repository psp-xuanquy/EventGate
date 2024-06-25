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
        Task<int> AddAsync(Voucher voucher);
        Task<int> UpdateAsync(Voucher voucher);
        Task<int> DeleteAsync(string voucherId);
        Task<Voucher> GetByIdAsync(string voucherId);
        Task<IEnumerable<Voucher>> GetAllAsync();
    }
}
