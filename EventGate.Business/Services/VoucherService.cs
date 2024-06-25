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
    public class VoucherService : IVoucherService
    {
        private readonly IVoucherRepository _voucherRepository;
        private readonly IMapper<Voucher, VoucherDTO> _voucherMapper;

        public VoucherService(IVoucherRepository voucherRepository, IMapper<Voucher, VoucherDTO> voucherMapper)
        {
            _voucherRepository = voucherRepository;
            _voucherMapper = voucherMapper;
        }

        public async Task<ServiceResult<int>> AddAsync(VoucherDTO voucherDTO)
        {
            var result = new ServiceResult<int>();

            try
            {
                var voucher = _voucherMapper.Map(voucherDTO);
                var affectedRows = await _voucherRepository.AddAsync(voucher);
                result.IsSuccess = true;
                result.Data = affectedRows;
                result.Status = 200;
                result.ErrorMessage = "Voucher added successfully";
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.ErrorMessage = ex.Message;
                result.Status = 500;
            }

            return result;
        }

        public async Task<ServiceResult<int>> UpdateAsync(VoucherDTO voucherDTO)
        {
            var result = new ServiceResult<int>();

            try
            {
                var voucher = _voucherMapper.Map(voucherDTO);
                var affectedRows = await _voucherRepository.UpdateAsync(voucher);
                result.IsSuccess = true;
                result.Data = affectedRows;
                result.Status = 200;
                result.ErrorMessage = "Voucher updated successfully";
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.Status = 500;
                result.ErrorMessage = ex.Message;
            }

            return result;
        }

        public async Task<ServiceResult<int>> DeleteAsync(string voucherId)
        {
            var result = new ServiceResult<int>();

            try
            {
                var affectedRows = await _voucherRepository.DeleteAsync(voucherId);
                result.IsSuccess = true;
                result.Data = affectedRows;
                result.Status = 200;
                result.ErrorMessage = "Voucher deleted successfully";
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.Status = 500;
                result.ErrorMessage = ex.Message;
            }

            return result;
        }

        public async Task<ServiceResult<IEnumerable<Voucher>>> GetAllAsync()
        {
            var result = new ServiceResult<IEnumerable<Voucher>>();

            try
            {
                var vouchers = await _voucherRepository.GetAllAsync();
                result.IsSuccess = true;
                result.Data = vouchers;
                result.Status = 200;
                result.ErrorMessage = "Retrieved all vouchers successfully";
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.Status = 500;
                result.ErrorMessage = ex.Message;
            }

            return result;
        }

        public async Task<ServiceResult<Voucher>> GetByIdAsync(string voucherId)
        {
            var result = new ServiceResult<Voucher>();

            try
            {
                var voucher = await _voucherRepository.GetByIdAsync(voucherId);
                if (voucher == null)
                {
                    result.IsSuccess = false;
                    result.Status = 404;
                    result.ErrorMessage = "Voucher not found";
                }
                else
                {
                    result.IsSuccess = true;
                    result.Data = voucher;
                    result.Status = 200;
                    result.ErrorMessage = "Retrieved voucher successfully";
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
