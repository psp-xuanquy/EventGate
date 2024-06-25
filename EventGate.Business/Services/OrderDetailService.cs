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
    public class OrderDetailService : IOrderDetailService
    {
        private readonly IOrderDetailRepository _orderDetailRepository;
        private readonly IMapper<OrderDetail, OrderDetailDTO> _orderDetailMapper;

        public OrderDetailService(IOrderDetailRepository orderDetailRepository, IMapper<OrderDetail, OrderDetailDTO> orderDetailMapper)
        {
            _orderDetailRepository = orderDetailRepository;
            _orderDetailMapper = orderDetailMapper;
        }

        public async Task<ServiceResult<int>> AddAsync(OrderDetailDTO orderDetailDTO)
        {
            var result = new ServiceResult<int>();

            try
            {
                var orderDetail = _orderDetailMapper.Map(orderDetailDTO);
                var affectedRows = await _orderDetailRepository.AddAsync(orderDetail);
                result.IsSuccess = true;
                result.Data = affectedRows;
                result.Status = 200;
                result.ErrorMessage = "Order detail added successfully";
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.ErrorMessage = ex.Message;
                result.Status = 500;
            }

            return result;
        }

        public async Task<ServiceResult<int>> UpdateAsync(OrderDetailDTO orderDetailDTO)
        {
            var result = new ServiceResult<int>();

            try
            {
                var orderDetail = _orderDetailMapper.Map(orderDetailDTO);
                var affectedRows = await _orderDetailRepository.UpdateAsync(orderDetail);
                result.IsSuccess = true;
                result.Data = affectedRows;
                result.Status = 200;
                result.ErrorMessage = "Order detail updated successfully";
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.Status = 500;
                result.ErrorMessage = ex.Message;
            }

            return result;
        }

        public async Task<ServiceResult<int>> DeleteAsync(string orderDetailId)
        {
            var result = new ServiceResult<int>();

            try
            {
                var affectedRows = await _orderDetailRepository.DeleteAsync(orderDetailId);
                result.IsSuccess = true;
                result.Data = affectedRows;
                result.Status = 200;
                result.ErrorMessage = "Order detail deleted successfully";
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.Status = 500;
                result.ErrorMessage = ex.Message;
            }

            return result;
        }

        public async Task<ServiceResult<IEnumerable<OrderDetail>>> GetAllAsync()
        {
            var result = new ServiceResult<IEnumerable<OrderDetail>>();

            try
            {
                var orderDetails = await _orderDetailRepository.GetAllAsync();
                result.IsSuccess = true;
                result.Data = orderDetails;
                result.Status = 200;
                result.ErrorMessage = "Retrieved all order details successfully";
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.Status = 500;
                result.ErrorMessage = ex.Message;
            }

            return result;
        }

        public async Task<ServiceResult<OrderDetail>> GetByIdAsync(string orderDetailId)
        {
            var result = new ServiceResult<OrderDetail>();

            try
            {
                var orderDetail = await _orderDetailRepository.GetByIdAsync(orderDetailId);
                if (orderDetail == null)
                {
                    result.IsSuccess = false;
                    result.Status = 404;
                    result.ErrorMessage = "Order detail not found";
                }
                else
                {
                    result.IsSuccess = true;
                    result.Data = orderDetail;
                    result.Status = 200;
                    result.ErrorMessage = "Retrieved order detail successfully";
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
