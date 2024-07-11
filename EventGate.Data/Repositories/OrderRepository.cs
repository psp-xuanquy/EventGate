using EventGate.Data.Entity;
using EventGate.Data.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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

        // Get all Orders
        public async Task<List<Order>> GetAllAsync()
        {
            return await _context.Orders
                .Include(o => o.OrderDetails)
                    .ThenInclude(od => od.Ticket)
                .Where(o => o.DeletedTime == null)
                .ToListAsync();
        }

        // Get Order by ID
        public async Task<Order> GetByIdAsync(string orderId)
        {
            return await _context.Orders
                .Include(o => o.OrderDetails)
                    .ThenInclude(od => od.Ticket)
                .Where(o => o.DeletedTime == null)
                .FirstOrDefaultAsync(o => o.OrderID == orderId);
        }

        // Get Order by ID
        public async Task<Order> GetByUserIdAsync(string userId)
        {
            return await _context.Orders
                .Include(o => o.OrderDetails)
                    .ThenInclude(od => od.Ticket)
                .Where(o => o.DeletedTime == null)
                .FirstOrDefaultAsync(o => o.UserID == userId);
        }

        // Add Order
        public async Task<Order> AddAsync(string user, Order order, List<OrderDetail> orderDetails)
        {
            order.OrderDate = DateTime.Now;
            order.CreatedBy = user;
            order.LastUpdatedBy = user;
            order.LastUpdatedTime = DateTime.Now;

            order.OrderDetails = orderDetails;
            order.TotalPrice = orderDetails.Sum(od => od.UnitPrice * od.Quantity);

            _context.Orders.Add(order);
            _context.OrderDetails.AddRange(orderDetails);

            await _context.SaveChangesAsync();
            return order;
        }

        // Update Order
        public async Task<int> UpdateAsync(string user, string orderId, Order order, List<OrderDetail> orderDetails)
        {
            var existingOrder = await _context.Orders
                .Include(o => o.OrderDetails)
                .FirstOrDefaultAsync(o => o.OrderID == orderId && o.DeletedTime == null);

            if (existingOrder != null)
            {
                existingOrder.PaymentMethod = order.PaymentMethod;
                existingOrder.Status = order.Status;
                existingOrder.TotalPrice = orderDetails.Sum(od => od.UnitPrice * od.Quantity);
                existingOrder.UserID = order.UserID;
                existingOrder.LastUpdatedBy = user;
                existingOrder.LastUpdatedTime = DateTime.Now;

                _context.OrderDetails.RemoveRange(existingOrder.OrderDetails);
                _context.OrderDetails.AddRange(orderDetails);

                return await _context.SaveChangesAsync();
            }
            return 0;
        }


        // Delete Order
        public async Task<int> DeleteAsync(string user, string orderId)
        {
            var orderToDelete = await _context.Orders.FirstOrDefaultAsync(o => o.OrderID == orderId && o.DeletedTime == null);
            if (orderToDelete != null)
            {
                orderToDelete.DeletedBy = user;
                orderToDelete.DeletedTime = DateTime.Now;

                //return await _context.SaveChangesAsync();
                var result = await _context.SaveChangesAsync();

                if (result > 0)
                {
                    Console.WriteLine($"SUCCESS: Order with ID ( {orderId} ) DELETED successfully");
                    return result;
                }
                else
                {
                    Console.WriteLine($"ERROR: Failed to delete order with ID ( {orderId} ). No changes were made.");
                    return 0;
                }
            }
            else
            {
                Console.WriteLine($"ERROR: Order with ID ( {orderId} ) not found or already deleted.");
                return 0;
            }
            //return 0;
        }
    }
}
