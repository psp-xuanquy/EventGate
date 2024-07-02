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
    public class EventClubService : IEventClubService
    {
        private readonly IEventClubsRepository _eventClubsRepository;
        private readonly IEventRepository _eventRepository;
        private readonly IClubRepository _clubRepository;
        private readonly IMapper _mapper;

        public EventClubService(IEventClubsRepository eventClubsRepository, 
            IEventRepository eventRepository,
            IClubRepository clubRepository,
            IMapper mapper)
        {
            _eventRepository = eventRepository;
            _clubRepository = clubRepository;
            _eventClubsRepository = eventClubsRepository;
            _mapper = mapper;
        }

        //Get All
        public async Task<IActionResult> GetAllAsync()
        {
            List<EventClub> eventclubs = await _eventClubsRepository.GetAllAsync();
            return new OkObjectResult(_mapper.Map<List<EventClubDTOResponse>>(eventclubs));
        }


        //Add
        public async Task<IActionResult> AddEventClub(EventClubDTORequest eventclub)
        {
            Club club = await _clubRepository.GetByIdAsync(eventclub.ClubId);
            if(club  == null)
            {
                return new BadRequestObjectResult($"Club với id: '{eventclub.ClubId}' không tìm thấy hoặc đã bị xóa");
            }

            //Event events = await _eventRepository.GetEventById(eventclub.EventId);
            //if(events == null)
            //{
            //    return new BadRequestObjectResult($"Event với id: '{eventclub.EventId}' không tìm thấy hoặc đã bị xóa");
            //}

            var eventClubEntity = _mapper.Map<EventClub>(eventclub);

            //Check xem event này đã được tổ chức bởi câu lạc bộ nào hay chưa - 1 Sự kiện chỉ được tổ chức bởi 1 CLB?
            var existingOrganizedEvent = await _eventClubsRepository.GetEventClubByEventIdAsync(eventclub.EventId, eventclub.ClubId);
            if(existingOrganizedEvent != null)
            {
                return new BadRequestObjectResult($"Sự kiện này đã được tổ chức bởi một câu lạc bộ khác.");
            }

            //Check xem cái event đó có đang tồn tại trong danh sách thời gian đang diễn ra sự kiện của Club đó không? 
            //var existingEventClub = await _eventClubsRepository.CheckDuplicateEventClub(eventclub.EventId, eventclub.ClubId);
            //if (existingEventClub != null)
            //{
            //    return new BadRequestObjectResult($"Event {events.EventName} đã tồn tại trong danh sách những sự kiện đang diễn ra của câu lạc bộ, vui lòng thêm vào một sự kiện mới khác.");
            //}

            int rs = await _eventClubsRepository.AddEventClub(eventClubEntity);
            if(rs == 0)
            {
                return new BadRequestObjectResult("Add Event Club thất bại!");
            }

            return new OkObjectResult("Add Event Club thành công!");
        }


        //Find Event By Club

        public Task<IActionResult> FindEventByClub(int id)
        {
            throw new NotImplementedException();
        }

        //Find By EventClubId



        //Update
        public async Task<IActionResult> UpdateEventClub(string id, EventClubDTORequest eventclub)
        {
            EventClub existEventClub = await _eventClubsRepository.FindEventClubById(id);
            if(existEventClub == null)
            {
                return new BadRequestObjectResult($"EventClub với id: '{id}' không tìm thấy hoặc đã bị xóa");
            }

            Club club = await _clubRepository.GetByIdAsync(eventclub.ClubId);
            if (club == null)
            {
                return new BadRequestObjectResult($"Club với id: '{eventclub.ClubId}' không tìm thấy hoặc đã bị xóa");
            }

            //Event events = await _eventRepository.GetEventById(eventclub.EventId);
            //if (events == null)
            //{
            //    return new BadRequestObjectResult($"Event với id: '{eventclub.EventId}' không tìm thấy hoặc đã bị xóa");
            //}

            _mapper.Map(eventclub, existEventClub);

            int rs = await _eventClubsRepository.UpdateAsync(existEventClub);
            if (rs == 0)
            {
                return new BadRequestObjectResult("Update Event Club thất bại!");
            }

            return new OkObjectResult("Update Event Club thành công!");

        }


        //Delete
        public async Task<IActionResult> DeleteAsync(string id)
        {
            EventClub eventclub = await _eventClubsRepository.FindEventClubById(id);
            if (eventclub == null)
            {
                return new BadRequestObjectResult($"EventClub với id: '{id}' không tìm thấy hoặc đã bị xóa!");
            }

            int rs = await _eventClubsRepository.DeleteAsync(eventclub);
            if (rs == 0)
            {
                return new BadRequestObjectResult("Delete Eventclub thất bại!");
            }

            return new OkObjectResult("Delete Eventclub thành công!");
        }
  
    }
}
