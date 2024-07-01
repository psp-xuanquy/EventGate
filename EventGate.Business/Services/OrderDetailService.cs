using AutoMapper;
using EventGate.Business.Mappers;
using EventGate.Business.Models.DTOs.Request.Order;
using EventGate.Business.Services.Interface;
using EventGate.Data.Entity;
using EventGate.Data.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Business.Services
{
    public class OrderDetailService : IOrderDetailService
    {
        private readonly IOrderDetailRepository _orderDetailRepository;
        private readonly IMapper _mapper;

        public OrderDetailService(IOrderDetailRepository orderDetailRepository, IMapper mapper)
        {
            _orderDetailRepository = orderDetailRepository;
            _mapper = mapper;
        }

        // Get OrderDetail by ID
        public async Task<OrderDetailDTO> GetOrderDetailByIdAsync(string orderDetailId)
        {
            var orderDetail = await _orderDetailRepository.GetByIdAsync(orderDetailId);
            if (orderDetail == null)
            {
                throw new Exception($"OrderDetail with ID ( {orderDetailId} ) NOT FOUND");
            }
            return _mapper.Map<OrderDetailDTO>(orderDetail);
        }

        // Get OrderDetails by OrderID
        public async Task<List<OrderDetailDTO>> GetOrderDetailsByOrderIdAsync(string orderId)
        {
            var orderDetails = await _orderDetailRepository.GetByOrderIdAsync(orderId);
            if (orderDetails == null)
            {
                throw new Exception($"Order with ID ( {orderId} ) NOT FOUND");
            }
            return _mapper.Map<List<OrderDetailDTO>>(orderDetails);
        }
    }
}
