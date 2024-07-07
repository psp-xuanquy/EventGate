using AutoMapper;
using EventGate.Business.Models.DTOs.Request.ChatRoom;
using EventGate.Business.Models.DTOs.Request.EventHistory;
using EventGate.Business.Models.DTOs.Request.User;
using EventGate.Business.Models.DTOs.Response.Event;
using EventGate.Business.Models.DTOs.Response.User;
using EventGate.Data.Entities;
using EventGate.Data.Entity;
using Microsoft.AspNetCore.Http.HttpResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EventGate.Business.Mappers
{
    public class Mapper : Profile
    {

        public Mapper()
        {
            CreateMap<User, UserDTORequest>().ReverseMap();
            CreateMap<User, UserDTOResponse>().ReverseMap();
            CreateMap<User, UpdateUserDTORequest>().ReverseMap();
            CreateMap<User, UserInfoDTOResponse>().ReverseMap();
            CreateMap<UserChatRoomAdd, UserChatRoom>();
            CreateMap<ChatRoomAddDTO, ChatRoom>();
            CreateMap<ChatRoomDTORequest, ChatRoom>();
            CreateMap<ChatUppdateDTO, ChatRoom>();

            CreateMap<User, UserDTO>();


            CreateMap<Event, EventDTO>();


            CreateMap<Club, ClubDTO>()
            .ForMember(dest => dest.President, opt => opt.MapFrom(src => src.President));


            CreateMap<EventClub, EventClubDTOResponse>()
                .ForMember(dest => dest.Event, opt => opt.MapFrom(src => src.Event))
                .ForMember(dest => dest.Club, opt => opt.MapFrom(src => src.Club));


            CreateMap<EventClub, EventClubDTORequest>()
                .ReverseMap();


            CreateMap<UserEvent, UserEventDTORequest>().ReverseMap();
            CreateMap<UserEvent, UserEventDTOResponse>()
                 .ForMember(dest => dest.Event, opt => opt.MapFrom(src => src.Event))
                .ForMember(dest => dest.User, opt => opt.MapFrom(src => src.User));

            CreateMap<User, UserHistoryDTORequest>()
                .ForMember(dest => dest.UserID, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.UserName))
                .ForMember(dest => dest.Password, opt => opt.MapFrom(src => src.PasswordHash))
                .ForMember(dest => dest.Mail, opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.Phone, opt => opt.MapFrom(src => src.PhoneNumber))
                .ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.Address))
                .ForMember(dest => dest.IdentityCard, opt => opt.MapFrom(src => src.IdentityCard))
                .ForMember(dest => dest.DateOfBirth, opt => opt.MapFrom(src => src.DateOfBirth))
                .ForMember(dest => dest.ArchivedDate, opt => opt.MapFrom(src => DateTime.Now));


            CreateMap<UserHistoryDTORequest, UserHistory>()
             .ForMember(dest => dest.UserID, opt => opt.MapFrom(src => src.UserID));

            CreateMap<UserHistory, UserHistoryDTOResponse>()
            .ForMember(dest => dest.DateOfBirth, opt => opt.MapFrom(src => src.DateOfBirth.HasValue ? src.DateOfBirth.Value.ToString("dd/MM/yyyy") : null))
            .ForMember(dest => dest.ArchivedDate, opt => opt.MapFrom(src => src.ArchivedDate.HasValue ? src.ArchivedDate.Value.ToString("dd/MM/yyyy") : null));


            //EventHistory Mapping

            CreateMap<EventHistory, EventHistoryDTOResponse>()
                .ForMember(dest => dest.EventType, opt => opt.MapFrom(src => src.EventType))
                .ForMember(dest => dest.ArchiveDate, opt => opt.MapFrom(src => src.ArchiveDate.HasValue ? src.ArchiveDate.Value.ToString("dd/MM/yyyy") : null))
                .ForMember(dest => dest.StartDate, opt => opt.MapFrom(src => src.StartDate.HasValue ? src.StartDate.Value.ToString("dd/MM/yyyy") : null))
            .ForMember(dest => dest.EndDate, opt => opt.MapFrom(src => src.EndDate.HasValue ? src.EndDate.Value.ToString("dd/MM/yyyy") : null)); ;
            

            CreateMap<EventType, EventTypeDTO>()
                .ForMember(dest => dest.EventTypeName, opt => opt.MapFrom(src => src.EventTypeName));

            CreateMap<EventHistory, EventHistoryDTORequest>()
                .ForMember(dest => dest.EventID, opt => opt.MapFrom(src => src.EventID))
                .ForMember(dest => dest.EventName, opt => opt.MapFrom(src => src.EventName))
                .ForMember(dest => dest.Location, opt => opt.MapFrom(src => src.Location))
                .ForMember(dest => dest.Content, opt => opt.MapFrom(src => src.Content))
                .ForMember(dest => dest.StartDate, opt => opt.MapFrom(src => src.StartDate))
                .ForMember(dest => dest.EndDate, opt => opt.MapFrom(src => src.EndDate))
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status))
                .ForMember(dest => dest.TicketQuantity, opt => opt.MapFrom(src => src.TicketQuantity))
                .ForMember(dest => dest.PosterImage, opt => opt.MapFrom(src => src.PosterImage))
                .ForMember(dest => dest.QRCode, opt => opt.MapFrom(src => src.QRCode))
                .ForMember(dest => dest.ArchiveDate, opt => opt.MapFrom(src => DateTime.Now))
                .ForMember(dest => dest.EventTypeID, opt => opt.MapFrom(src => src.EventTypeID))
                .ReverseMap();

            CreateMap<Event, EventHistoryDTORequest>()
                .ForMember(dest => dest.EventID, opt => opt.MapFrom(src => src.EventID))
                .ForMember(dest => dest.EventName, opt => opt.MapFrom(src => src.EventName))
                .ForMember(dest => dest.Location, opt => opt.MapFrom(src => src.Location))
                .ForMember(dest => dest.Content, opt => opt.MapFrom(src => src.Content))
                .ForMember(dest => dest.StartDate, opt => opt.MapFrom(src => src.StartDate))
                .ForMember(dest => dest.EndDate, opt => opt.MapFrom(src => src.EndDate))
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status))
                .ForMember(dest => dest.TicketQuantity, opt => opt.MapFrom(src => src.TicketQuantity))
                .ForMember(dest => dest.PosterImage, opt => opt.MapFrom(src => src.PosterImage))
                .ForMember(dest => dest.QRCode, opt => opt.MapFrom(src => src.QRCode))
                .ForMember(dest => dest.ArchiveDate, opt => opt.MapFrom(src => DateTime.Now))
                .ForMember(dest => dest.EventTypeID, opt => opt.MapFrom(src => src.EventTypeID));

            //UserEventHistory
            CreateMap<UserEvent, UserEventHistoryDTORequest>()
                 .ForMember(dest => dest.ArchiveDate, opt => opt.MapFrom(src => DateTime.Now));
            CreateMap<UserEventHistory, UserEventHistoryDTORequest>().ReverseMap();
            CreateMap<UserEventHistory, UserEventHistoryDTOResponse>()
                 .ForMember(dest => dest.ArchiveDate, opt => opt.MapFrom(src => src.ArchiveDate.HasValue ? src.ArchiveDate.Value.ToString("dd/MM/yyyy") : null));

        }
    }
}

