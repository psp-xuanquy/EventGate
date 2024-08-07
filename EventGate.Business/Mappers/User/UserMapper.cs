﻿using AutoMapper;
using EventGate.Business.Models.DTOs.Request.User;
using EventGate.Business.Models.DTOs.Response.User;
using EventGate.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EventGate.Business.Mappers
{
    public class UserMapper  : Profile {

        public UserMapper() {
            CreateMap<User, UserDTORequest>().ReverseMap();
            CreateMap<User, UserDTOResponse>().ReverseMap()
            .ForMember(dest => dest.Avatar, opt => opt.MapFrom(src => src.Avatar));
            CreateMap<User, UpdateUserDTORequest>().ReverseMap();
        }
        
    }
}

