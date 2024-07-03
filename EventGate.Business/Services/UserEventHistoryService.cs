using AutoMapper;
using EventGate.Business.Models.DTOs.Response.Event;
using EventGate.Business.Models.DTOs.Response.User;
using EventGate.Business.Services.Interface;
using EventGate.Data.Entity;
using EventGate.Data.Repositories;
using EventGate.Data.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Business.Services
{
    public class UserEventHistoryService : IUserEventHistoryService
    {
        private readonly IUserEventHistoryRepository _userEventHistoryRepository;
        private readonly IMapper _mapper;

        public UserEventHistoryService(IUserEventHistoryRepository userEventHistoryRepository, IMapper mapper)
        {
            _mapper = mapper;
            _userEventHistoryRepository = userEventHistoryRepository;
        }
        

        public async Task<IActionResult> GetAllAsync()
        {
            List<UserEventHistory> userEventHistory = await _userEventHistoryRepository.GetAllAsync();
            return new OkObjectResult(_mapper.Map<List<UserEventHistoryDTOResponse>>(userEventHistory));
        }
    }
}
