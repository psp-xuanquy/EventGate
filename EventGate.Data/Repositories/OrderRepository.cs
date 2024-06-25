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
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _context;

        public OrderRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<int> AddAsync(Order order)
        {
            var existingOrder = await _context.Orders.FirstOrDefaultAsync(o => o.OrderID == order.OrderID);
            if (existingOrder != null)
            {
                throw new Exception("Order already exists");
            }

            await _context.Orders.AddAsync(order);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> UpdateAsync(Order order)
        {
            var existingOrder = await _context.Orders.FirstOrDefaultAsync(o => o.OrderID == order.OrderID);
            if (existingOrder == null)
            {
                throw new Exception("Order does not exist");
            }

            _context.Orders.Update(order);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> DeleteAsync(string orderId)
        {
            var order = await _context.Orders.FirstOrDefaultAsync(o => o.OrderID == orderId);
            if (order == null)
            {
                throw new Exception("Order does not exist");
            }

            _context.Orders.Remove(order);
            return await _context.SaveChangesAsync();
        }

        public async Task<Order> GetByIdAsync(string orderId)
        {
            var order = await _context.Orders.FirstOrDefaultAsync(o => o.OrderID == orderId);
            if (order == null)
            {
                throw new Exception("Order does not exist");
            }
            return order;
        }

        public async Task<IEnumerable<Order>> GetAllAsync()
        {
            return await _context.Orders.ToListAsync();
        }
    }
}
