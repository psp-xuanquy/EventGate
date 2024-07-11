using EventGate.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Data.Repositories.Interface
{
    public interface IOrderRepository
    {
        Task<List<Order>> GetAllAsync();
        Task<Order> GetByIdAsync(string orderId);
        Task<Order> GetByUserIdAsync(string userId);
        Task<Order> AddAsync(string user, Order order, List<OrderDetail> orderDetails);
        Task<int> UpdateAsync(string user, string orderId, Order order, List<OrderDetail> orderDetails);
        Task<int> DeleteAsync(string user, string orderId);
    }
}
