using AutoMapper;
using EventGate.Business.Models.DTOs.Request;
using EventGate.Business.Services.Interface;
using EventGate.Data.Entity;
using EventGate.Data.Repositories;
using EventGate.Data.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventGate.Business.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly ITicketRepository _ticketRepository;
        private readonly IMapper _mapper;

        public OrderService(IOrderRepository orderRepository, ITicketRepository ticketRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _ticketRepository = ticketRepository;
            _mapper = mapper;
        }

        // Get all Orders
        public async Task<List<OrderDTO>> GetAllOrdersAsync()
        {
            var orders = await _orderRepository.GetAllAsync();
            return _mapper.Map<List<OrderDTO>>(orders);
        }

        // Get Order by ID
        public async Task<OrderDTO> GetOrderByIdAsync(string orderId)
        {
            var order = await _orderRepository.GetByIdAsync(orderId);
            if (order == null)
            {
                throw new Exception($"Order with ID ( {orderId} ) NOT FOUND");
            }
            return _mapper.Map<OrderDTO>(order);
        }

        // Add Order
        public async Task<int> AddOrderAsync(string user, OrderDTO addOrderDto)
        {
            var order = _mapper.Map<Order>(addOrderDto);
            var orderDetails = new List<OrderDetail>();

            foreach (var detailDto in addOrderDto.OrderDetails)
            {
                var ticket = await _ticketRepository.GetByIdAsync(detailDto.TicketID);
                if (ticket == null)
                {
                    throw new Exception($"Ticket with ID ( {detailDto.TicketID} ) NOT FOUND");
                }

                var orderDetail = new OrderDetail
                {
                    OrderDetailID = Guid.NewGuid().ToString(),
                    OrderID = order.OrderID,
                    TicketID = ticket.TicketID,
                    Quantity = detailDto.Quantity,
                    UnitPrice = ticket.Price
                };

                orderDetails.Add(orderDetail);
            }

            order.TotalPrice = orderDetails.Sum(od => od.UnitPrice * od.Quantity);
            return await _orderRepository.AddAsync(user, order, orderDetails);
        }

        // Update Order
        public async Task<int> UpdateOrderAsync(string user, string orderId, OrderDTO updateOrderDto)
        {
            if (!await _orderRepository.IsOrderExistAsync(orderId))
            {
                throw new Exception($"Order with ID ( {orderId} ) NOT FOUND");
            }

            var order = _mapper.Map<Order>(updateOrderDto);
            var orderDetails = new List<OrderDetail>();

            foreach (var detailDto in updateOrderDto.OrderDetails)
            {
                var ticket = await _ticketRepository.GetByIdAsync(detailDto.TicketID);
                if (ticket == null)
                {
                    throw new Exception($"Ticket with ID ( {detailDto.TicketID} ) NOT FOUND");
                }

                var orderDetail = new OrderDetail
                {
                    OrderDetailID = Guid.NewGuid().ToString(),
                    OrderID = orderId,
                    TicketID = ticket.TicketID,
                    Quantity = detailDto.Quantity,
                    UnitPrice = ticket.Price
                };

                orderDetails.Add(orderDetail);
            }

            order.TotalPrice = orderDetails.Sum(od => od.UnitPrice * od.Quantity);
            return await _orderRepository.UpdateAsync(user, orderId, order, orderDetails);
        }

        // Delete Order
        public async Task<int> DeleteOrderAsync(string user, string orderId)
        {
            return await _orderRepository.DeleteAsync(user, orderId);
        }
    }
}
