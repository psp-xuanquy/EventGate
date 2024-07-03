using AutoMapper;
using EventGate.Business.Models.DTOs.Request.User;
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
    public class EventFeedBackService : IEventFeedBackService
    {
        private readonly IEventFeedBackRepository _userFeedbackRepository;
        private readonly IEventRepository _eventRepository;
        private readonly IUserPropository _userRepository;
        private readonly IMapper _mapper;

        public EventFeedBackService(IEventFeedBackRepository userEventRepository,
            IEventRepository eventRepository,
            IUserPropository userRepository,
            IMapper mapper)
        {
            _mapper = mapper;
            _userFeedbackRepository = userEventRepository;
            _eventRepository = eventRepository;
            _userRepository = userRepository;
        }

        //Get All UserEvent
        public async Task<IActionResult> GetAllAsync()
        {
            List<EventFeedback> users = await _userFeedbackRepository.GetAllAsync();
            return new OkObjectResult(_mapper.Map<List<UserEventDTOResponse>>(users));
        }

        //Get All UserEvent Deleted
        public async Task<IActionResult> GetAllDeletedAsync()
        {
            List<EventFeedback> users = await _userFeedbackRepository.GetAllDeletedAsync();
            return new OkObjectResult(_mapper.Map<List<UserEventDTOResponse>>(users));
        }


        //Find By Id
        public async Task<IActionResult> GetByIdAsync(string id)
        {
            EventFeedback user = await _userFeedbackRepository.GetByIdAsync(id);
            if (user == null)
            {
                return new BadRequestObjectResult($"UserFeedbackId: '{id}' not found or has been deleted!");
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

            //Event events = await _eventRepository.GetEventById(userEvent.EventId);
            //if (events == null)
            //{
            //    return new BadRequestObjectResult($"EventId: '{userEvent.EventId}' not found or has been deleted");
            //}

            var userEventEntity = _mapper.Map<EventFeedback>(userEvent);

            int rs = await _userFeedbackRepository.AddEventFeedBackAsync(userEventEntity);
            if (rs == 0)
            {
                return new BadRequestObjectResult("Add UserFeedBack fail!");
            }

            return new OkObjectResult("Add UserFeedBack success!");
        }


        //Update UserEvent
        public async Task<IActionResult> UpdateAsync(UserEventDTORequest userEventDTO, string id)
        {
            EventFeedback userEvent = await _userFeedbackRepository.GetByIdAsync(id);
            if (userEvent == null)
            {
                return new BadRequestObjectResult($"UserFeedBackId: '{id}' not found or has been deleted!");
            }

            User user = await _userRepository.GetByIdAsync(userEventDTO.UserId);
            if (user == null)
            {
                return new BadRequestObjectResult($"UserId: '{userEventDTO.UserId}' not found or has been deleted");
            }

            //Event events = await _eventRepository.GetEventById(userEventDTO.EventId);
            //if (events == null)
            //{
            //    return new BadRequestObjectResult($"EventId: '{userEventDTO.EventId}' not found or has been deleted");
            //}

            _mapper.Map(userEventDTO, userEvent);

            int rs = await _userFeedbackRepository.UpdateAsync(userEvent);
            if (rs == 0)
            {
                return new BadRequestObjectResult("Update UserFeedBack fail!");
            }

            return new OkObjectResult("Update UserFeedBack success!");
        }


        //Delete User
        public async Task<IActionResult> DeleteAsync(string id)
        {
            EventFeedback userEvent = await _userFeedbackRepository.GetByIdAsync(id);
            if (userEvent == null)
            {
                return new BadRequestObjectResult($"UserFeedBackId: '{id}' not found or has been deleted!");
            }

            int rs = await _userFeedbackRepository.DeleteAsync(userEvent);
            if (rs == 0)
            {
                return new BadRequestObjectResult("Delete UserFeedBack fail!");
            }

            return new OkObjectResult("Delete UserFeedBack success!");
        }
    }
}
