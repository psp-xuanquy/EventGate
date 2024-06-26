using AutoMapper;
using EventGate.Business.Models.DTOs.Request;
using EventGate.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EventGate.Business.Mappers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Club, ClubDTO>().ReverseMap();
        }
    }
}
