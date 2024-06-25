using EventGate.Business.Models.DTOs.Request;
using EventGate.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Business.Services.Interface
{
    public interface IOrderService
    {
        Task<ServiceResult<int>> AddAsync(OrderDTO orderDTO);
        Task<ServiceResult<int>> UpdateAsync(OrderDTO orderDTO);
        Task<ServiceResult<int>> DeleteAsync(string orderId);
        Task<ServiceResult<Order>> GetByIdAsync(string orderId);
        Task<ServiceResult<IEnumerable<Order>>> GetAllAsync();
    }
}
