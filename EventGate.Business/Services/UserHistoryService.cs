using AutoMapper;
using EventGate.Business.Models.DTOs.Response.User;
using EventGate.Business.Services.Interface;
using EventGate.Data.Entity;
using EventGate.Data.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Business.Services
{
    public class UserHistoryService : IUserHistoryService
    {
        private readonly IUserHistoryRepository _userHistoryRepository;
        private readonly IMapper _mapper;

        public UserHistoryService(IUserHistoryRepository userHistoryRepository, IMapper mapper)
        {
            _mapper = mapper;
            _userHistoryRepository = userHistoryRepository;
        }

        public async Task<IActionResult> GetAllAsync()
        {
            List<UserHistory> users = await _userHistoryRepository.GetAllAsync();
            return new OkObjectResult(_mapper.Map<List<UserHistoryDTOResponse>>(users));
        }
    }
}
