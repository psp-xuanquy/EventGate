using EventGate.Business.Models.DTOs.Request.Order;
using EventGate.Business.Models.DTOs.Response;
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
        Task<List<OrderDetailDTOResponse>> GetOrderDetailsByOrderIdAsync(string orderId);
        Task<OrderDetailDTOResponse> GetOrderDetailByIdAsync(string orderDetailId);
    }
}
