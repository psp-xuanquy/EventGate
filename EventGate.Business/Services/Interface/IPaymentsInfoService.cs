using EventGate.Business.Models.DTOs.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Business.Services.Interface
{
    public interface IPaymentsInfoService
    {
        Task<List<PaymentsInfoDTO>> GetAllPaymentsInfosAsync();
        Task<PaymentsInfoDTO> GetPaymentsInfoByIdAsync(string paymentsInfoId);
        Task<int> AddPaymentsInfoAsync(string user, PaymentsInfoDTO addPaymentsInfoDto);
        Task<int> UpdatePaymentsInfoAsync(string user, string paymentsInfoId, PaymentsInfoDTO updatePaymentsInfoDto);
        Task<int> DeletePaymentsInfoAsync(string user, string paymentsInfoId);
    }
}
