using AutoMapper;
using EventGate.Business.Models.DTOs.Request;
using EventGate.Business.Models.DTOs.Request.Order;
using EventGate.Business.Models.DTOs.Response;
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
            // Mapping for Club
            CreateMap<Club, ClubDTO>().ReverseMap();

            // Mapping for Ticket
            CreateMap<Ticket, TicketDTO>()
                .ForMember(dest => dest.QRCodeBase64, opt => opt.MapFrom(src => Convert.ToBase64String(src.QRCode)))
                .ReverseMap()
                .ForMember(dest => dest.QRCode, opt => opt.MapFrom(src => Convert.FromBase64String(src.QRCodeBase64)));

            // Mapping for Seat
            CreateMap<Seat, SeatDTO>().ReverseMap();

            // Mapping for EventType
            CreateMap<EventType, EventTypeDTO>().ReverseMap();

            // Mapping for EventRule
            CreateMap<EventRule, EventRuleDTO>().ReverseMap();

            // Mapping for Voucher
            CreateMap<Voucher, VoucherDTO>().ReverseMap();

            // Mapping for Order
            CreateMap<Order, OrderDTO>().ReverseMap();
            CreateMap<AddOrderDTO, Order>();
            CreateMap<UpdateOrderDTO, Order>();

            // Mapping for OrderDetail
            CreateMap<OrderDetail, OrderDetailDTO>().ReverseMap();
            CreateMap<OrderDetailDTO, OrderDetail>().ReverseMap();

            // Mapping for OrderDetail response
            CreateMap<OrderDetail, OrderDetailDTOResponse>().ReverseMap();
        }
    }
}
