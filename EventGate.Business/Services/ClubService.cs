using AutoMapper;
using EventGate.Business.Models.DTOs.Request;
using EventGate.Business.Services.Interface;
using EventGate.Data.Entity;
using EventGate.Data.Repositories;
using EventGate.Data.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace EventGate.Business.Services
{
    public class ClubService : IClubService
    {
        private readonly IClubRepository _clubRepository;
        private readonly IUserPropository _userRepository;
        private readonly IMapper _mapper;

        public ClubService(IClubRepository clubRepository, IUserPropository userRepository, IMapper mapper)
        {
            _clubRepository = clubRepository;
            _userRepository = userRepository;
            _mapper = mapper;
        }

        // Get all Club
        public async Task<List<ClubDTO>> GetAllClubsAsync()
        {
            List<Club> clubs = await _clubRepository.GetAllAsync();
            return _mapper.Map<List<ClubDTO>>(clubs);
        }

        // Get Club by ID
        public async Task<ClubDTO> GetClubByIdAsync(string clubId)
        {
            Club club = await _clubRepository.GetByIdAsync(clubId);
            if (club == null)
            {
                throw new Exception($"Club with ID ( {clubId} ) NOT FOUND");
            }

            return _mapper.Map<ClubDTO>(club);
        }

        // Add Club
        public async Task<int> AddClubAsync(string user, ClubDTO addClubDto)
        {
            var existingClub = await _clubRepository.GetByNameAsync(addClubDto.Name);
            if (existingClub != null)
            {
                throw new Exception($"Club with the SAME NAME '{addClubDto.Name}' already EXISTS");
            }

            var existingPresident = await _userRepository.GetByIdAsync(addClubDto.PresidentID);
            if (existingPresident == null)
            {
                throw new Exception($"President with ID ( {addClubDto.PresidentID} ) NOT FOUND.");
            }

            if (addClubDto.MemberQuantity <= 0)
            {
                throw new Exception("The number of members must be GREATER THAN 0");
            }

            var club = _mapper.Map<Club>(addClubDto);
            return await _clubRepository.AddAsync(user, club);
        }

        // Update Club
        public async Task<int> UpdateClubAsync(string user, string clubId, ClubDTO updateClubDto)
        {
            var existingClub = await _clubRepository.GetByIdAsync(clubId);
            if (existingClub == null)
            {
                throw new Exception($"Club with ID ( {clubId} ) NOT FOUND.");
            }

            if (updateClubDto.MemberQuantity <= 0)
            {
                throw new Exception("The number of members must be GREATER THAN 0");
            }

            var existingPresident = await _userRepository.GetByIdAsync(updateClubDto.PresidentID);
            if (existingPresident == null)
            {
                throw new Exception($"President with ID ( {updateClubDto.PresidentID} ) NOT FOUND.");
            }

            var club = _mapper.Map<Club>(updateClubDto);
            return await _clubRepository.UpdateAsync(user, clubId, club);
        }

        // Delete Club
        public async Task<int> DeleteClubAsync(string user, string clubId)
        {
            var existingClub = await _clubRepository.GetByIdAsync(clubId);
            if (existingClub == null)
            {
                throw new Exception($"Club with ID ( {clubId} ) NOT FOUND.");
            }

            return await _clubRepository.DeleteAsync(user, clubId);
        }
    }
}
