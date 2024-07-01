using AutoMapper;
using EventGate.Business.Models.DTOs.Request;
using EventGate.Business.Models.DTOs.Request.Order;
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
            CreateMap<Ticket, TicketDTO>()
                .ForMember(dest => dest.QRCodeBase64, opt => opt.MapFrom(src => Convert.ToBase64String(src.QRCode)))
                .ReverseMap()
                .ForMember(dest => dest.QRCode, opt => opt.MapFrom(src => Convert.FromBase64String(src.QRCodeBase64)));
            CreateMap<Seat, SeatDTO>().ReverseMap();
            CreateMap<Voucher, VoucherDTO>().ReverseMap();
            CreateMap<Order, OrderDTO>().ReverseMap();
            CreateMap<AddOrderDTO, Order>();
            CreateMap<UpdateOrderDTO, Order>();
            CreateMap<OrderDetail, OrderDetailDTO>().ReverseMap();
            CreateMap<OrderDetailDTO, OrderDetail>().ReverseMap();
        }
    }
}
