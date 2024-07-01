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
        private readonly AppDbContext _context;

        public OrderDetailRepository(AppDbContext context)
        {
            _context = context;
        }

        // Get OrderDetail by ID
        public async Task<OrderDetail> GetByIdAsync(string orderDetailId)
        {
            return await _context.OrderDetails
                .FirstOrDefaultAsync(od => od.OrderDetailID == orderDetailId && od.DeletedTime == null);
        }

        // Get OrderDetails by OrderID
        public async Task<List<OrderDetail>> GetByOrderIdAsync(string orderId)
        {
            return await _context.OrderDetails
                .Where(od => od.OrderID == orderId && od.DeletedTime == null)
                .ToListAsync();
        }

        // Add OrderDetails by OrderID
        public async Task AddAsync(string user, OrderDetail orderDetail)
        {
            orderDetail.CreatedBy = user;
            orderDetail.LastUpdatedBy = user;
            orderDetail.LastUpdatedTime = DateTime.Now;

            _context.OrderDetails.Add(orderDetail);
            await _context.SaveChangesAsync();
        }

        // Delete OrderDetails by OrderID
        public async Task DeleteByOrderIdAsync(string user, string orderId)
        {
            var orderDetailsToDelete = await _context.OrderDetails
                .Where(od => od.OrderID == orderId && od.DeletedTime == null)
                .ToListAsync();

            foreach (var orderDetail in orderDetailsToDelete)
            {
                orderDetail.DeletedBy = user;
                orderDetail.DeletedTime = DateTime.Now;
            }

            await _context.SaveChangesAsync();
        }
    }
}
