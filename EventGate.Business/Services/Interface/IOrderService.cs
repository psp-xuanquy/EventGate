using EventGate.Business.Models.DTOs.Request.Order;
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
        Task<List<OrderDTO>> GetAllOrdersAsync();
        Task<OrderDTO> GetOrderByIdAsync(string orderId);
        Task<int> AddOrderAsync(string user, AddOrderDTO addOrderDto);
        Task<int> UpdateOrderAsync(string user, string orderId, UpdateOrderDTO updateOrderDto);
        Task<int> DeleteOrderAsync(string user, string orderId);
    }
}
