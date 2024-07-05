using AutoMapper;
using EventGate.Business.Models.DTOs.Request.User;
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
    public class UserEventService : IUserEventService
    {

        private readonly IUserEventRepository _userEventRepository;
        private readonly IEventRepository _eventRepository;
        private readonly IUserPropository _userRepository;
        private readonly IUserEventHistoryRepository _userEventHistoryRepository;
        private readonly IMapper _mapper;

        public UserEventService(IUserEventRepository userEventRepository,
            IEventRepository eventRepository,
            IUserPropository userRepository,
            IUserEventHistoryRepository userEventHistoryRepository,
            IMapper mapper)
        {
            _mapper = mapper;
            _userEventRepository = userEventRepository;
            _eventRepository = eventRepository;
            _userRepository = userRepository;
            _userEventHistoryRepository = userEventHistoryRepository;
        }

        //Get All UserEvent
        public async Task<IActionResult> GetAllAsync()
        {
            List<UserEvent> users = await _userEventRepository.GetAllAsync();
            return new OkObjectResult(_mapper.Map<List<UserEventDTOResponse>>(users));
        }

        //Get All UserEvent Deleted
        public async Task<IActionResult> GetAllDeletedAsync()
        {
            List<UserEvent> users = await _userEventRepository.GetAllDeletedAsync();
            return new OkObjectResult(_mapper.Map<List<UserEventDTOResponse>>(users));
        }


        //Find By Id
        public async Task<IActionResult> GetByIdAsync(string id)
        {
            UserEvent user = await _userEventRepository.GetByIdAsync(id);
            if (user == null)
            {
                return new BadRequestObjectResult($"UserEventId: '{id}' not found or has been deleted!");
            }
            return new OkObjectResult(_mapper.Map<UserEventDTOResponse>(user));
        }

        //Add UserEvent
        public async Task<IActionResult> AddAsync(UserEventDTORequest userEvent)
        {
            User user = await _userRepository.GetByIdAsync(userEvent.UserId);
            if (user == null)
            {
                return new BadRequestObjectResult($"UserId: '{userEvent.UserId}' not found or has been deleted");
            }

            Event events = await _eventRepository.GetByIdAsync(userEvent.EventId);
            if (events == null)
            {
                return new BadRequestObjectResult($"EventId: '{userEvent.EventId}' not found or has been deleted");
            }

            var userEventEntity = _mapper.Map<UserEvent>(userEvent);

            int rs = await _userEventRepository.AddUserEventAsync(userEventEntity);
            if (rs == 0)
            {
                return new BadRequestObjectResult("Add UserEvent fail!");
            }

            return new OkObjectResult("Add UserEvent success!");
        }


        //Update UserEvent
        public async Task<IActionResult> UpdateAsync(UserEventDTORequest userEventDTO, string id)
        {
            UserEvent userEvent = await _userEventRepository.GetByIdAsync(id);
            if (userEvent == null)
            {
                return new BadRequestObjectResult($"UserEventId: '{id}' not found or has been deleted!");
            }

            User user = await _userRepository.GetByIdAsync(userEventDTO.UserId);
            if (user == null)
            {
                return new BadRequestObjectResult($"UserId: '{userEventDTO.UserId}' not found or has been deleted");
            }

            Event events = await _eventRepository.GetByIdAsync(userEventDTO.EventId);
            if (events == null)
            {
                return new BadRequestObjectResult($"EventId: '{userEventDTO.EventId}' not found or has been deleted");
            }

            _mapper.Map(userEventDTO, userEvent);

            int rs = await _userEventRepository.UpdateAsync(userEvent);
            if (rs == 0)
            {
                return new BadRequestObjectResult("Update UserEvent fail!");
            }

            return new OkObjectResult("Update UserEvent success!");
        }


        //Delete User
        public async Task<IActionResult> DeleteAsync(string id)
        {
            UserEvent userEvent = await _userEventRepository.GetByIdAsync(id);
            if (userEvent == null)
            {
                return new BadRequestObjectResult($"UserEventId: '{id}' not found or has been deleted!");
            }

            // Map User to UserHistoryDTORequest
            var userEventHistoryDTO = _mapper.Map<UserEventHistoryDTORequest>(userEvent);

            // Map UserHistoryDTORequest to UserHistory entity
            var userEventHistory = _mapper.Map<UserEventHistory>(userEventHistoryDTO);

            // Add UserHistory entry
            await _userEventHistoryRepository.AddUserEventHistoryAsync(userEventHistory);


            int rs = await _userEventRepository.DeleteAsync(userEvent);
            if (rs == 0)
            {
                return new BadRequestObjectResult("Delete UserEvent fail!");
            }

            return new OkObjectResult("Delete UserEvent success!");
        }
    }
}
