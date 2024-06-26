using AutoMapper;
using EventGate.Business.Mappers;
using EventGate.Business.Models.DTOs.Request;
using EventGate.Business.Services.Interface;
using EventGate.Data.Entity;
using EventGate.Data.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Business.Services
{
    public class SeatService : ISeatService
    {
        private readonly ISeatRepository _seatRepository;
        private readonly IMapper _mapper;

        public SeatService(ISeatRepository seatRepository, IMapper mapper)
        {
            _seatRepository = seatRepository;
            _mapper = mapper;
        }

        // Get all Seat
        public async Task<List<SeatDTO>> GetAllSeatsAsync()
        {
            var seats = await _seatRepository.GetAllAsync();
            return _mapper.Map<List<SeatDTO>>(seats);
        }

        // Get Seat by ID
        public async Task<SeatDTO> GetSeatByIdAsync(string seatId)
        {
            var seat = await _seatRepository.GetByIdAsync(seatId);
            if (seat == null)
            {
                throw new Exception($"Seat with ID ( {seatId} ) NOT FOUND");
            }
            return _mapper.Map<SeatDTO>(seat);
        }

        // Add Seat
        public async Task<int> AddSeatAsync(string user, SeatDTO addSeatDto)
        {
            var existingSeat = await _seatRepository.GetByHallRowAndNumberAsync(addSeatDto.Hall, addSeatDto.Row, addSeatDto.Number);
            if (existingSeat != null)
            {
                throw new Exception($"Seat with Hall ({addSeatDto.Hall}), Row ({addSeatDto.Row}), Number ({addSeatDto.Number}) ALREADY EXISTS");
            }

            var seat = _mapper.Map<Seat>(addSeatDto);
            return await _seatRepository.AddAsync(user, seat);
        }

        // Update Seat
        public async Task<int> UpdateSeatAsync(string user, string seatId, SeatDTO updateSeatDto)
        {
            var existingSeat = await _seatRepository.GetByIdAsync(seatId);
            if (existingSeat == null)
            {
                throw new Exception($"Seat with ID ({seatId}) NOT FOUND");
            }

            var conflictingSeat = await _seatRepository.GetByHallRowAndNumberAsync(updateSeatDto.Hall, updateSeatDto.Row, updateSeatDto.Number);
            if (conflictingSeat != null && conflictingSeat.SeatID != seatId)
            {
                throw new Exception($"Seat with Hall ({updateSeatDto.Hall}), Row ({updateSeatDto.Row}), Number ({updateSeatDto.Number}) ALREADY EXISTS");
            }

            var seat = _mapper.Map<Seat>(updateSeatDto);
            return await _seatRepository.UpdateAsync(user, seatId, seat);
        }

        // Delete Seat
        public async Task<int> DeleteSeatAsync(string user, string seatId)
        {
            var existingSeat = await _seatRepository.GetByIdAsync(seatId);
            if (existingSeat == null)
            {
                throw new Exception($"Seat with ID ({seatId}) NOT FOUND");
            }

            return await _seatRepository.DeleteAsync(user, seatId);
        }
    }
}
