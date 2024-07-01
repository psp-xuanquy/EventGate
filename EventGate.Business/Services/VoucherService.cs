using AutoMapper;
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
        private readonly IUserPropository _userRepository;
        //private readonly IEventRepository _voucherRepository;
        private readonly IMapper _mapper;

        public VoucherService(IVoucherRepository voucherRepository, IUserPropository userRepository, IMapper mapper)
        {
            _voucherRepository = voucherRepository;
            _userRepository = userRepository;
            _mapper = mapper;
        }

        // Get all Voucher
        public async Task<List<VoucherDTO>> GetAllVouchersAsync()
        {
            var vouchers = await _voucherRepository.GetAllAsync();
            return _mapper.Map<List<VoucherDTO>>(vouchers);
        }

        // Get Voucher by ID
        public async Task<VoucherDTO> GetVoucherByIdAsync(string voucherId)
        {
            var voucher = await _voucherRepository.GetByIdAsync(voucherId);
            if (voucher == null)
            {
                throw new Exception($"Voucher with ID ( {voucherId} ) NOT FOUND");
            }

            return _mapper.Map<VoucherDTO>(voucher);
        }

        // Add Voucher
        public async Task<int> AddVoucherAsync(string user, VoucherDTO addVoucherDto)
        {
            var existingVoucher = await _voucherRepository.GetByCodeAsync(addVoucherDto.Code);
            if (existingVoucher != null)
            {
                throw new Exception($"Voucher with the SAME CODE '{addVoucherDto.Code}' already EXISTS");
            }

            var existingUser = await _userRepository.GetByIdAsync(addVoucherDto.UserID);
            if (existingUser == null)
            {
                throw new Exception($"User with ID ( {addVoucherDto.UserID} ) NOT FOUND.");
            }

            //var existingEvent = await _eventRepository.GetByIdAsync(addVoucherDto.EventID);
            //if (existingEvent == null)
            //{
            //    throw new Exception($"Event with ID ( {addVoucherDto.EventID} ) NOT FOUND.");
            //}

            var voucher = _mapper.Map<Voucher>(addVoucherDto);
            return await _voucherRepository.AddAsync(user, voucher);
        }

        // Update Voucher
        public async Task<int> UpdateVoucherAsync(string user, string voucherId, VoucherDTO updateVoucherDto)
        {
            var existingVoucherId = await _voucherRepository.GetByIdAsync(voucherId);
            if (existingVoucherId == null)
            {
                throw new Exception($"Voucher with ID ( {voucherId} ) NOT FOUND");
            }

            var existingVoucherCode = await _voucherRepository.GetByCodeAsync(updateVoucherDto.Code);
            if (existingVoucherCode != null)
            {
                throw new Exception($"Voucher with the SAME CODE '{updateVoucherDto.Code}' already EXISTS");
            }

            var existingUser = await _userRepository.GetByIdAsync(updateVoucherDto.UserID);
            if (existingUser == null)
            {
                throw new Exception($"User with ID ( {updateVoucherDto.UserID} ) NOT FOUND.");
            }

            //var existingEvent = await _eventRepository.GetByIdAsync(updateVoucherDto.EventID);
            //if (existingEvent == null)
            //{
            //    throw new Exception($"Event with ID ( {updateVoucherDto.EventID} ) NOT FOUND.");
            //}

            var voucher = _mapper.Map<Voucher>(updateVoucherDto);
            return await _voucherRepository.UpdateAsync(user, voucherId, voucher);
        }

        // Delete Voucher
        public async Task<int> DeleteVoucherAsync(string user, string voucherId)
        {
            var existingVoucher = await _voucherRepository.GetByIdAsync(voucherId);
            if (existingVoucher == null)
            {
                throw new Exception($"Voucher with ID ( {voucherId} ) NOT FOUND");
            }

            return await _voucherRepository.DeleteAsync(user, voucherId);
        }
    }
}
