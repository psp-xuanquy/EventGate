using EventGate.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Data.Repositories.Interface
{
    public interface IOrderDetailRepository
    {
        Task<int> AddAsync(OrderDetail orderDetail);
        Task<int> UpdateAsync(OrderDetail orderDetail);
        Task<int> DeleteAsync(string orderDetailId);
        Task<OrderDetail> GetByIdAsync(string orderDetailId);
        Task<IEnumerable<OrderDetail>> GetAllAsync();
    }
}
