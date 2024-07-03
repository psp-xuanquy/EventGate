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
    public class EventHistoryService : IEventHistoryService
    {
        private readonly IEventHistoryRepository _eventHistoryRepository;
        private readonly IMapper _mapper;

        public EventHistoryService(IEventHistoryRepository eventHistoryRepository, IMapper mapper)
        {
            _mapper = mapper;
            _eventHistoryRepository = eventHistoryRepository;
        }

        public async Task<IActionResult> GetAllAsync()
        {
            List<EventHistory> eventHistory = await _eventHistoryRepository.GetAllAsync();
            return new OkObjectResult(_mapper.Map<List<EventHistoryDTOResponse>>(eventHistory));
        }
    }
}
