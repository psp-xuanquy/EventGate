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

        public async Task<int> AddAsync(OrderDetail orderDetail)
        {
            var existingOrderDetail = await _context.OrderDetails.FirstOrDefaultAsync(od => od.OrderDetailID == orderDetail.OrderDetailID);
            if (existingOrderDetail != null)
            {
                throw new Exception("Order detail already exists");
            }

            await _context.OrderDetails.AddAsync(orderDetail);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> UpdateAsync(OrderDetail orderDetail)
        {
            var existingOrderDetail = await _context.OrderDetails.FirstOrDefaultAsync(od => od.OrderDetailID == orderDetail.OrderDetailID);
            if (existingOrderDetail == null)
            {
                throw new Exception("Order detail does not exist");
            }

            _context.OrderDetails.Update(orderDetail);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> DeleteAsync(string orderDetailId)
        {
            var orderDetail = await _context.OrderDetails.FirstOrDefaultAsync(od => od.OrderDetailID == orderDetailId);
            if (orderDetail == null)
            {
                throw new Exception("Order detail does not exist");
            }

            _context.OrderDetails.Remove(orderDetail);
            return await _context.SaveChangesAsync();
        }

        public async Task<OrderDetail> GetByIdAsync(string orderDetailId)
        {
            var orderDetail = await _context.OrderDetails.FirstOrDefaultAsync(od => od.OrderDetailID == orderDetailId);
            if (orderDetail == null)
            {
                throw new Exception("Order detail does not exist");
            }
            return orderDetail;
        }

        public async Task<IEnumerable<OrderDetail>> GetAllAsync()
        {
            return await _context.OrderDetails.ToListAsync();
        }
    }
}
