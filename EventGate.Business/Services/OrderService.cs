using AutoMapper;
using EventGate.Business.Models.DTOs.Request.Order;
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
        private readonly IUserPropository _userRepository;
        private readonly ITicketRepository _ticketRepository;
        private readonly IOrderDetailRepository _orderDetailRepository;
        private readonly IMapper _mapper;

        public OrderService(
            IOrderRepository orderRepository,
            IUserPropository userRepository,
            ITicketRepository ticketRepository,
            IOrderDetailRepository orderDetailRepository,
            IMapper mapper)
        {
            _orderRepository = orderRepository;
            _ticketRepository = ticketRepository;
            _userRepository = userRepository;
            _orderDetailRepository = orderDetailRepository;
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
                throw new Exception($"Order with ID ({orderId}) NOT FOUND");
            }
            return _mapper.Map<OrderDTO>(order);
        }

        // Add Order
        public async Task<int> AddOrderAsync(string user, AddOrderDTO addOrderDto)
        {
            var existingUser = await _userRepository.GetByIdAsync(addOrderDto.UserID);
            if (existingUser == null)
            {
                throw new Exception($"User with ID ({addOrderDto.UserID}) NOT FOUND.");
            }

            var orderDetails = new List<OrderDetail>();

            foreach (var orderDetailDto in addOrderDto.OrderDetails)
            {
                var existingTicket = await _ticketRepository.GetByIdAsync(orderDetailDto.TicketID);
                if (existingTicket == null)
                {
                    throw new Exception($"Ticket with ID ({orderDetailDto.TicketID}) NOT FOUND.");
                }

                if (orderDetailDto.Quantity <= 0 || existingTicket.Price <= 0)
                {
                    throw new ArgumentException("Quantity and UnitPrice must be GREATER THAN 0.");
                }

                var orderDetail = new OrderDetail
                {
                    OrderID = null,
                    Quantity = orderDetailDto.Quantity,
                    UnitPrice = existingTicket.Price,
                    TicketID = orderDetailDto.TicketID
                };

                orderDetails.Add(orderDetail);
            }

            var order = _mapper.Map<Order>(addOrderDto);
            order.OrderDate = DateTime.Now;
            order.TotalPrice = orderDetails.Sum(od => od.Quantity * od.UnitPrice);

            return await _orderRepository.AddAsync(user, order, orderDetails);
        }

        // Update Order
        public async Task<int> UpdateOrderAsync(string user, string orderId, UpdateOrderDTO updateOrderDto)
        {
            var existingOrder = await _userRepository.GetByIdAsync(orderId);
            if (existingOrder == null)
            {
                throw new Exception($"Order with ID ({orderId}) NOT FOUND");
            }

            var existingUser = await _userRepository.GetByIdAsync(updateOrderDto.UserID);
            if (existingUser == null)
            {
                throw new Exception($"User with ID ({updateOrderDto.UserID}) NOT FOUND.");
            }

            var orderDetails = new List<OrderDetail>();

            foreach (var orderDetailDto in updateOrderDto.OrderDetails)
            {
                var existingTicket = await _ticketRepository.GetByIdAsync(orderDetailDto.TicketID);
                if (existingTicket == null)
                {
                    throw new Exception($"Ticket with ID ({orderDetailDto.TicketID}) NOT FOUND.");
                }

                if (orderDetailDto.Quantity <= 0 || existingTicket.Price <= 0)
                {
                    throw new ArgumentException("Quantity and UnitPrice must be GREATER THAN 0.");
                }

                var orderDetail = new OrderDetail
                {
                    OrderID = orderId,
                    Quantity = orderDetailDto.Quantity,
                    UnitPrice = existingTicket.Price,
                    TicketID = orderDetailDto.TicketID
                };

                orderDetails.Add(orderDetail);
            }

            var order = _mapper.Map<Order>(updateOrderDto);
            order.TotalPrice = orderDetails.Sum(od => od.Quantity * od.UnitPrice);

            return await _orderRepository.UpdateAsync(user, orderId, order, orderDetails);
        }


        // Delete Order
        public async Task<int> DeleteOrderAsync(string user, string orderId)
        {
            var existingOrder = await _orderRepository.GetByIdAsync(orderId);
            if (existingOrder == null)
            {
                throw new Exception($"Order with ID ({orderId}) NOT FOUND");
            }

            await _orderDetailRepository.DeleteByOrderIdAsync(user, orderId);
            return await _orderRepository.DeleteAsync(user, orderId);
        }
    }
}
