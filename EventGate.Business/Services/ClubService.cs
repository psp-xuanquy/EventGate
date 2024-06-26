using AutoMapper;
using EventGate.Business.Models.DTOs.Request;
using EventGate.Business.Services.Interface;
using EventGate.Data.Entity;
using EventGate.Data.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Business.Services
{
    public class ClubService : IClubService
    {
        private readonly IClubRepository _clubRepository;
        private readonly IMapper _mapper;

        public ClubService(IClubRepository clubRepository, IMapper mapper)
        {
            _clubRepository = clubRepository;
            _mapper = mapper;
        }

        public async Task<List<ClubDTO>> GetAllClubsAsync()
        {
            List<Club> clubs = await _clubRepository.GetAllAsync();
            var clubDtos = _mapper.Map<List<ClubDTO>>(clubs);
            return clubDtos;
        }

        public async Task<ClubDTO> GetClubByIdAsync(string clubId)
        {
            Club club = await _clubRepository.GetByIdAsync(clubId);
            if (club == null)
            {
                throw new Exception($"Club with ID ( {clubId} ) NOT FOUND");
            }

            var clubDto = _mapper.Map<ClubDTO>(club);
            return clubDto;
        }

        public async Task<int> AddClubAsync(string user, ClubDTO addClubDto)
        {
            //var existingPresident = await _userRepository.GetByIdAsync(clubId);
            //if (existingPresident == null)
            //{
            //    throw new Exception($"President with ID ( {updateClubDto.PresidentID} ) NOT FOUND.");
            //}

            var club = _mapper.Map<Club>(addClubDto);
            int result = await _clubRepository.AddAsync(user, club);
            return result;
        }

        public async Task<int> UpdateClubAsync(string user, string clubId, ClubDTO updateClubDto)
        {
            var existingClub = await _clubRepository.GetByIdAsync(clubId);
            if (existingClub == null)
            {
                throw new Exception($"Club with ID ( {clubId} ) NOT FOUND.");
            }

            if (updateClubDto.MemberQuantity <= 0)
            {
                throw new Exception("The number of members must be greater than 0");
            }

            //var existingPresident = await _userRepository.GetByIdAsync(clubId);
            //if (existingPresident == null)
            //{
            //    throw new Exception($"President with ID ( {updateClubDto.PresidentID} ) NOT FOUND.");
            //}

            var club = _mapper.Map<Club>(updateClubDto);
            int result = await _clubRepository.UpdateAsync(user, clubId, club);
            return result;
        }

        public async Task<int> DeleteClubAsync(string user, string clubId)
        {
            var existingClub = await _clubRepository.GetByIdAsync(clubId);
            if (existingClub == null)
            {
                throw new Exception($"Club with ID ( {clubId} ) NOT FOUND.");
            }

            int result = await _clubRepository.DeleteAsync(user, clubId);
            return result;
        }
    }
}
