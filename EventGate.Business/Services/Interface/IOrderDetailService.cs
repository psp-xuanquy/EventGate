using EventGate.Business.Models.DTOs.Request;
using EventGate.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Business.Services.Interface
{
    public interface IOrderDetailService
    {
        Task<ServiceResult<int>> AddAsync(OrderDetailDTO orderDetailDTO);
        Task<ServiceResult<int>> UpdateAsync(OrderDetailDTO orderDetailDTO);
        Task<ServiceResult<int>> DeleteAsync(string orderDetailId);
        Task<ServiceResult<OrderDetail>> GetByIdAsync(string orderDetailId);
        Task<ServiceResult<IEnumerable<OrderDetail>>> GetAllAsync();
    }
}
