using EventGate.Data.Entity;
using EventGate.Data.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Data.Repositories
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        private readonly DbContext _context;

        public OrderDetailRepository(DbContext context)
        {
            _context = context;
        }

        // Get OrderDetail by ID
        public async Task<OrderDetail> GetByIdAsync(string orderDetailId)
        {
            return await _context.Set<OrderDetail>()
                .FirstOrDefaultAsync(od => od.OrderDetailID == orderDetailId && od.DeletedTime == null);
        }

        // Get OrderDetails by OrderID
        public async Task<List<OrderDetail>> GetByOrderIdAsync(string orderId)
        {
            return await _context.Set<OrderDetail>()
                .Where(od => od.OrderID == orderId && od.DeletedTime == null)
                .ToListAsync();
        }
    }
}
