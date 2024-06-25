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
    public class SeatService : ISeatService
    {
        private readonly ISeatRepository _seatRepository;
        private readonly IMapper<Seat, SeatDTO> _seatMapper;

        public SeatService(ISeatRepository seatRepository, IMapper<Seat, SeatDTO> seatMapper)
        {
            _seatRepository = seatRepository;
            _seatMapper = seatMapper;
        }

        public async Task<ServiceResult<int>> AddAsync(SeatDTO seatDTO)
        {
            var result = new ServiceResult<int>();

            try
            {
                var seat = _seatMapper.Map(seatDTO);
                var affectedRows = await _seatRepository.AddAsync(seat);
                result.IsSuccess = true;
                result.Data = affectedRows;
                result.Status = 200;
                result.ErrorMessage = "Seat added successfully";
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.ErrorMessage = ex.Message;
                result.Status = 500;
            }

            return result;
        }

        public async Task<ServiceResult<int>> UpdateAsync(SeatDTO seatDTO)
        {
            var result = new ServiceResult<int>();

            try
            {
                var seat = _seatMapper.Map(seatDTO);
                var affectedRows = await _seatRepository.UpdateAsync(seat);
                result.IsSuccess = true;
                result.Data = affectedRows;
                result.Status = 200;
                result.ErrorMessage = "Seat updated successfully";
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.Status = 500;
                result.ErrorMessage = ex.Message;
            }

            return result;
        }

        public async Task<ServiceResult<int>> DeleteAsync(string seatId)
        {
            var result = new ServiceResult<int>();

            try
            {
                var affectedRows = await _seatRepository.DeleteAsync(seatId);
                result.IsSuccess = true;
                result.Data = affectedRows;
                result.Status = 200;
                result.ErrorMessage = "Seat deleted successfully";
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.Status = 500;
                result.ErrorMessage = ex.Message;
            }

            return result;
        }

        public async Task<ServiceResult<IEnumerable<Seat>>> GetAllAsync()
        {
            var result = new ServiceResult<IEnumerable<Seat>>();

            try
            {
                var seats = await _seatRepository.GetAllAsync();
                result.IsSuccess = true;
                result.Data = seats;
                result.Status = 200;
                result.ErrorMessage = "Retrieved all seats successfully";
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.Status = 500;
                result.ErrorMessage = ex.Message;
            }

            return result;
        }

        public async Task<ServiceResult<Seat>> GetByIdAsync(string seatId)
        {
            var result = new ServiceResult<Seat>();

            try
            {
                var seat = await _seatRepository.GetByIdAsync(seatId);
                if (seat == null)
                {
                    result.IsSuccess = false;
                    result.Status = 404;
                    result.ErrorMessage = "Seat not found";
                }
                else
                {
                    result.IsSuccess = true;
                    result.Data = seat;
                    result.Status = 200;
                    result.ErrorMessage = "Retrieved seat successfully";
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
