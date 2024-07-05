using AutoMapper;
using EventGate.Business.Models.DTOs.Request;
using EventGate.Business.Models.DTOs.Request.Order;
using EventGate.Business.Models.DTOs.Response;
using EventGate.Business.Models.DTOs.Response.Event;
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
            CreateMap<EventType, Models.DTOs.Request.EventTypeDTO>().ReverseMap();

            // Mapping for EventRule
            CreateMap<EventRule, EventRuleDTO>().ReverseMap();

            // Mapping for Voucher
            CreateMap<Voucher, VoucherDTO>().ReverseMap();

            // Mapping for Event
            CreateMap<Event, EventDTO>().ReverseMap();

            // Mapping for EventResponse
            CreateMap<Event, EventDTOResponse>()
                .ForMember(dest => dest.EventId, opt => opt.MapFrom(src => src.EventID.ToString()))
                .ForMember(dest => dest.EventTypeName, opt => opt.MapFrom(src => src.EventType.EventTypeName))
                .ForMember(dest => dest.ClubName, opt => opt.MapFrom(src => src.EventClubs.FirstOrDefault().Club.Name))
                .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Tickets.FirstOrDefault().Price));

            // Mapping for PaymentsInfo
            CreateMap<PaymentsInfo, PaymentsInfoDTO>().ReverseMap();

            // Mapping for Order
            CreateMap<Order, OrderDTO>().ReverseMap();
            CreateMap<AddOrderDTO, Order>();
            CreateMap<UpdateOrderDTO, Order>();

            // Mapping for OrderDetail
            CreateMap<OrderDetail, OrderDetailDTO>().ReverseMap();
            CreateMap<OrderDetailDTO, OrderDetail>().ReverseMap();

            // Mapping for OrderDetail response
            CreateMap<OrderDetail, OrderDetailDTOResponse>().ReverseMap();
            CreateMap<EventFeedback,EventFeedBackDTO>().ReverseMap();
            CreateMap<EventFeedback, EventFeedBackDTOResponse>().ReverseMap();
        }
    }
}
