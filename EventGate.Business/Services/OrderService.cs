using EventGate.Business.Mappers;
using EventGate.Business.Models.DTOs.Request;
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
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper<Order, OrderDTO> _orderMapper;

        public OrderService(IOrderRepository orderRepository, IMapper<Order, OrderDTO> orderMapper)
        {
            _orderRepository = orderRepository;
            _orderMapper = orderMapper;
        }

        public async Task<ServiceResult<int>> AddAsync(OrderDTO orderDTO)
        {
            var result = new ServiceResult<int>();

            try
            {
                var order = _orderMapper.Map(orderDTO);
                var affectedRows = await _orderRepository.AddAsync(order);
                result.IsSuccess = true;
                result.Data = affectedRows;
                result.Status = 200;
                result.ErrorMessage = "Order added successfully";
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.ErrorMessage = ex.Message;
                result.Status = 500;
            }

            return result;
        }

        public async Task<ServiceResult<int>> UpdateAsync(OrderDTO orderDTO)
        {
            var result = new ServiceResult<int>();

            try
            {
                var order = _orderMapper.Map(orderDTO);
                var affectedRows = await _orderRepository.UpdateAsync(order);
                result.IsSuccess = true;
                result.Data = affectedRows;
                result.Status = 200;
                result.ErrorMessage = "Order updated successfully";
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.Status = 500;
                result.ErrorMessage = ex.Message;
            }

            return result;
        }

        public async Task<ServiceResult<int>> DeleteAsync(string orderId)
        {
            var result = new ServiceResult<int>();

            try
            {
                var affectedRows = await _orderRepository.DeleteAsync(orderId);
                result.IsSuccess = true;
                result.Data = affectedRows;
                result.Status = 200;
                result.ErrorMessage = "Order deleted successfully";
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.Status = 500;
                result.ErrorMessage = ex.Message;
            }

            return result;
        }

        public async Task<ServiceResult<IEnumerable<Order>>> GetAllAsync()
        {
            var result = new ServiceResult<IEnumerable<Order>>();

            try
            {
                var orders = await _orderRepository.GetAllAsync();
                result.IsSuccess = true;
                result.Data = orders;
                result.Status = 200;
                result.ErrorMessage = "Retrieved all orders successfully";
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.Status = 500;
                result.ErrorMessage = ex.Message;
            }

            return result;
        }

        public async Task<ServiceResult<Order>> GetByIdAsync(string orderId)
        {
            var result = new ServiceResult<Order>();

            try
            {
                var order = await _orderRepository.GetByIdAsync(orderId);
                if (order == null)
                {
                    result.IsSuccess = false;
                    result.Status = 404;
                    result.ErrorMessage = "Order not found";
                }
                else
                {
                    result.IsSuccess = true;
                    result.Data = order;
                    result.Status = 200;
                    result.ErrorMessage = "Retrieved order successfully";
                }
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.Status = 500;
                result.ErrorMessage = ex.Message;
            }

            return result;
        }
    }
}
