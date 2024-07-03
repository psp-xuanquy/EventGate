using AutoMapper;
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
    public class PaymentsInfoService : IPaymentsInfoService
    {
        private readonly IPaymentsInfoRepository _paymentsInfoRepository;
        private readonly IEventRepository _eventRepository;
        private readonly IUserPropository _userRepository;
        private readonly IMapper _mapper;

        public PaymentsInfoService(IPaymentsInfoRepository paymentsInfoRepository, IUserPropository userRepository, IMapper mapper, IEventRepository eventRepository)
        {
            _paymentsInfoRepository = paymentsInfoRepository;
            _userRepository = userRepository;
            _mapper = mapper;
            _eventRepository = eventRepository;
        }

        // Get all PaymentsInfo
        public async Task<List<PaymentsInfoDTO>> GetAllPaymentsInfosAsync()
        {
            List<PaymentsInfo> paymentsInfos = await _paymentsInfoRepository.GetAllAsync();
            return _mapper.Map<List<PaymentsInfoDTO>>(paymentsInfos);
        }

        // Get PaymentsInfo by ID
        public async Task<PaymentsInfoDTO> GetPaymentsInfoByIdAsync(string paymentsInfoId)
        {
            PaymentsInfo paymentsInfo = await _paymentsInfoRepository.GetByIdAsync(paymentsInfoId);
            if (paymentsInfo == null)
            {
                throw new Exception($"PaymentsInfo with ID ( {paymentsInfoId} ) NOT FOUND");
            }

            return _mapper.Map<PaymentsInfoDTO>(paymentsInfo);
        }

        // Add PaymentsInfo
        public async Task<int> AddPaymentsInfoAsync(string user, PaymentsInfoDTO addPaymentsInfoDto)
        {
            var existingEventType = await _eventRepository.GetByIdAsync(addPaymentsInfoDto.EventID);
            if (existingEventType == null)
            {
                throw new Exception($"EventType with the ID '{addPaymentsInfoDto.EventID}' DOES NOT EXIST");
            }

            var paymentsInfo = _mapper.Map<PaymentsInfo>(addPaymentsInfoDto);
            return await _paymentsInfoRepository.AddAsync(user, paymentsInfo);
        }

        // Update PaymentsInfo
        public async Task<int> UpdatePaymentsInfoAsync(string user, string paymentsInfoId, PaymentsInfoDTO updatePaymentsInfoDto)
        {
            var existingEventType = await _eventRepository.GetByIdAsync(updatePaymentsInfoDto.EventID);
            if (existingEventType == null)
            {
                throw new Exception($"EventType with the ID '{updatePaymentsInfoDto.EventID}' DOES NOT EXIST");
            }

            var paymentsInfo = _mapper.Map<PaymentsInfo>(updatePaymentsInfoDto);
            return await _paymentsInfoRepository.UpdateAsync(user, paymentsInfoId, paymentsInfo);
        }

        // Delete PaymentsInfo
        public async Task<int> DeletePaymentsInfoAsync(string user, string paymentsInfoId)
        {
            var existingPaymentsInfo = await _paymentsInfoRepository.GetByIdAsync(paymentsInfoId);
            if (existingPaymentsInfo == null)
            {
                throw new Exception($"PaymentsInfo with ID ( {paymentsInfoId} ) NOT FOUND.");
            }

            return await _paymentsInfoRepository.DeleteAsync(user, paymentsInfoId);
        }
    }
}
