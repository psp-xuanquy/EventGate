using EventGate.Business.Mappers;
using EventGate.Business.Models.DTOs.Request;
using EventGate.Data.Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EventGate.Data.Repositories.Interface;
using EventGate.Business.Services.Interface;

namespace EventGate.Business.Services
{
    public class TicketService : ITicketService
    {
        private readonly ITicketRepository _ticketRepository;
        private readonly IMapper<Ticket, TicketDTO> _ticketMapper;

        public TicketService(ITicketRepository ticketRepository, IMapper<Ticket, TicketDTO> ticketMapper)
        {
            _ticketRepository = ticketRepository;
            _ticketMapper = ticketMapper;
        }

        public async Task<ServiceResult<int>> AddAsync(TicketDTO ticketDTO)
        {
            var result = new ServiceResult<int>();

            try
            {
                var ticket = _ticketMapper.Map(ticketDTO);
                var affectedRows = await _ticketRepository.AddAsync(ticket);
                result.IsSuccess = true;
                result.Data = affectedRows;
                result.Status = 200;
                result.ErrorMessage = "Ticket added successfully"; 
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.ErrorMessage = ex.Message;
                result.Status = 500; 
            }

            return result;
        }

        public async Task<ServiceResult<int>> UpdateAsync(TicketDTO ticketDTO)
        {
            var result = new ServiceResult<int>();

            try
            {
                var ticket = _ticketMapper.Map(ticketDTO);
                var affectedRows = await _ticketRepository.UpdateAsync(ticket);
                result.IsSuccess = true;
                result.Data = affectedRows;
                result.Status = 200; 
                result.ErrorMessage = "Ticket updated successfully"; 
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.Status = 500;
                result.ErrorMessage = ex.Message;
            }

            return result;
        }

        public async Task<ServiceResult<int>> DeleteAsync(string ticketId)
        {
            var result = new ServiceResult<int>();

            try
            {
                var affectedRows = await _ticketRepository.DeleteAsync(ticketId);
                result.IsSuccess = true;
                result.Data = affectedRows;
                result.Status = 200;
                result.ErrorMessage = "Ticket deleted successfully"; 
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.Status = 500; 
                result.ErrorMessage = ex.Message;
            }

            return result;
        }

        public async Task<ServiceResult<IEnumerable<Ticket>>> GetAllAsync()
        {
            var result = new ServiceResult<IEnumerable<Ticket>>();

            try
            {
                var tickets = await _ticketRepository.GetAllAsync();
                result.IsSuccess = true;
                result.Data = tickets;
                result.Status = 200; 
                result.ErrorMessage = "Retrieved all tickets successfully"; 
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.Status = 500; 
                result.ErrorMessage = ex.Message;
            }

            return result;
        }

        public async Task<ServiceResult<Ticket>> GetByIdAsync(string ticketId)
        {
            var result = new ServiceResult<Ticket>();

            try
            {
                var ticket = await _ticketRepository.GetByIdAsync(ticketId);
                if (ticket == null)
                {
                    result.IsSuccess = false;
                    result.Status = 404; 
                    result.ErrorMessage = "Ticket not found"; 
                }
                else
                {
                    result.IsSuccess = true;
                    result.Data = ticket;
                    result.Status = 200; 
                    result.ErrorMessage = "Retrieved ticket successfully"; 
                }
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.Status = 500; 
                result.ErrorMessage = ex.Message;
            }

            return result;
        }
    }
}
