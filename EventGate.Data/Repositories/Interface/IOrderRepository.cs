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
        Task<int> AddAsync(Order order);
        Task<int> UpdateAsync(Order order);
        Task<int> DeleteAsync(string orderId);
        Task<Order> GetByIdAsync(string orderId);
        Task<IEnumerable<Order>> GetAllAsync();
    }
}
