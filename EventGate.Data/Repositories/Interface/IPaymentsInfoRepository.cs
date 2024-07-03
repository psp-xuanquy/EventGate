using EventGate.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Data.Repositories.Interface
{
    public interface IPaymentsInfoRepository
    {
        Task<List<PaymentsInfo>> GetAllAsync();
        Task<PaymentsInfo> GetByIdAsync(string paymentsInfoId);
        Task<int> AddAsync(string user, PaymentsInfo addPaymentsInfo);
        Task<int> UpdateAsync(string user, string paymentsInfoId, PaymentsInfo updatePaymentsInfo);
        Task<int> DeleteAsync(string user, string paymentsInfoId);
    }
}
