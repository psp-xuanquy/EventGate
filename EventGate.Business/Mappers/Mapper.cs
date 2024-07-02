using AutoMapper;
using EventGate.Business.Models.DTOs.Request.User;
using EventGate.Business.Models.DTOs.Response.User;
using EventGate.Data.Entity;
using Microsoft.AspNetCore.Http.HttpResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EventGate.Business.Mappers
{
    public class Mapper  : Profile {

        public Mapper() {
            CreateMap<User, UserDTORequest>().ReverseMap();
            CreateMap<User, UserDTOResponse>().ReverseMap();
            CreateMap<User, UpdateUserDTORequest>().ReverseMap();


        CreateMap<User, UserDTO>();

        
        //CreateMap<Event, EventDTO>()
        //    .ForMember(dest => dest.StartDate, opt => opt.MapFrom(src => src.StartDate.HasValue ? src.StartDate.Value.ToString("dd/MM/yyyy") : null))
        //    .ForMember(dest => dest.EndDate, opt => opt.MapFrom(src => src.EndDate.HasValue ? src.EndDate.Value.ToString("dd/MM/yyyy") : null));

        
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
        }
    }
}

