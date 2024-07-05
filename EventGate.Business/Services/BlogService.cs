using AutoMapper;
using EventGate.Business.Models.DTOs.Request;
using EventGate.Business.Models.DTOs.Response;
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
    public class BlogService : IBlogService
    {
        private readonly IBlogRepository _blogRepository;
        private readonly IEventRepository _eventRepository;
        private readonly IUserPropository _userRepository;
        private readonly IMapper _mapper;

        public BlogService(IBlogRepository blogRepository,
            IEventRepository eventRepository,
            IUserPropository userRepository,
            IMapper mapper)
        {
            _mapper = mapper;
            _blogRepository = blogRepository;
            _eventRepository = eventRepository;
            _userRepository = userRepository;
        }

        //Get All UserEvent
        public async Task<IActionResult> GetAllAsync()
        {
            List<Blog> users = await _blogRepository.GetAllAsync();
            return new OkObjectResult(_mapper.Map<List<BlogDTO>>(users));
        }

        //Get All UserEvent Deleted
        public async Task<IActionResult> GetAllDeletedAsync()
        {
            List<Blog> users = await _blogRepository.GetAllDeletedAsync();
            return new OkObjectResult(_mapper.Map<List<BlogDTO>>(users));
        }


        //Find By Id
        public async Task<IActionResult> GetByIdAsync(string id)
        {
            Blog blog = await _blogRepository.GetByIdAsync(id);
            if (blog == null)
            {
                return new BadRequestObjectResult($"UserFeedbackId: '{id}' not found or has been deleted!");
            }
            return new OkObjectResult(_mapper.Map<BlogDTO>(blog));
        }

        //Add UserEvent
        public async Task<IActionResult> AddAsync(BlogDTO userEvent)
        {
            User user = await _userRepository.GetByIdAsync(userEvent.AuthorID);
            if (user == null)
            {
                return new BadRequestObjectResult($"UserId: '{userEvent.AuthorID}' not found or has been deleted");
            }

            //Event events = await _eventRepository.GetEventById(userEvent.EventId);
            //if (events == null)
            //{
            //    return new BadRequestObjectResult($"EventId: '{userEvent.EventId}' not found or has been deleted");
            //}

            var userEventEntity = _mapper.Map<Blog>(userEvent);

            int rs = await _blogRepository.AddEventFeedBackAsync(userEventEntity);
            if (rs == 0)
            {
                return new BadRequestObjectResult("Add UserFeedBack fail!");
            }

            return new OkObjectResult("Add UserFeedBack success!");
        }


        //Update UserEvent
        public async Task<IActionResult> UpdateAsync(BlogDTO userEventDTO, string id)
        {
             Blog userEvent = await _blogRepository.GetByIdAsync(id);
            if (userEvent == null)
            {
                return new BadRequestObjectResult($"UserFeedBackId: '{id}' not found or has been deleted!");
            }

            User user = await _userRepository.GetByIdAsync(userEventDTO.AuthorID);
            if (user == null)
            {
                return new BadRequestObjectResult($"UserId: '{userEventDTO.AuthorID}' not found or has been deleted");
            }

            //Event events = await _eventRepository.GetEventById(userEventDTO.EventId);
            //if (events == null)
            //{
            //    return new BadRequestObjectResult($"EventId: '{userEventDTO.EventId}' not found or has been deleted");
            //}

            _mapper.Map(userEventDTO, userEvent);

            int rs = await _blogRepository.UpdateAsync(userEvent);
            if (rs == 0)
            {
                return new BadRequestObjectResult("Update UserFeedBack fail!");
            }

            return new OkObjectResult("Update UserFeedBack success!");
        }


        //Delete User
        public async Task<IActionResult> DeleteAsync(string id)
        {
            Blog userEvent = await _blogRepository.GetByIdAsync(id);
            if (userEvent == null)
            {
                return new BadRequestObjectResult($"UserFeedBackId: '{id}' not found or has been deleted!");
            }

            int rs = await _blogRepository.DeleteAsync(userEvent);
            if (rs == 0)
            {
                return new BadRequestObjectResult("Delete UserFeedBack fail!");
            }

            return new OkObjectResult("Delete UserFeedBack success!");
        }
    }
}
