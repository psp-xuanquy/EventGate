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
        Task<List<OrderDetailDTO>> GetOrderDetailsByOrderIdAsync(string orderId);
        Task<OrderDetailDTO> GetOrderDetailByIdAsync(string orderDetailId);
    }
}
