using EventGate.Data.Entity;
using EventGate.Data.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Data.Repositories
{
    public class ClubRepository : IClubRepository
    {
        private readonly AppDbContext _context;

        public ClubRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Club>> GetAllAsync()
        {
            return await _context.Clubs
                .Include(c => c.President)
                .ToListAsync();
        }

        public async Task<Club> GetByIdAsync(string clubId)
        {
            var club = await _context.Clubs
                .Include(c => c.President)
                .FirstOrDefaultAsync(c => c.ClubID == clubId);

            if (club == null)
            {
                throw new Exception($"Club with ID ( {clubId} ) does not exist");
            }
            return club;
        }

        public async Task<int> AddAsync(string user, Club addClub)
        {
            var existingClub = await _context.Clubs.FirstOrDefaultAsync(c => c.ClubID == addClub.ClubID);
            if (existingClub != null)
            {
                throw new Exception("Club already EXISTS");
            }
            if (existingClub != null && existingClub.MemberQuantity <= 0)
            {
                throw new Exception("The number of members must be GREATER THAN 0");
            }

            addClub.CreatedBy = user;
            addClub.LastUpdatedBy = user;
            addClub.LastUpdatedTime = DateTime.Now;

            await _context.Clubs.AddAsync(addClub);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> UpdateAsync(string user, string clubId, Club updateClub)
        {
            var existingClub = await _context.Clubs.FirstOrDefaultAsync(c => c.ClubID == clubId);
            if (existingClub == null)
            {
                throw new Exception($"Club with ID ( {clubId} ) NOT FOUND");
            }

            existingClub.Name = updateClub.Name;
            existingClub.MemberQuantity = updateClub.MemberQuantity;
            existingClub.LogoClub = updateClub.LogoClub;
            existingClub.Description = updateClub.Description;
            existingClub.PresidentID = updateClub.PresidentID;
            existingClub.LastUpdatedBy = user;
            existingClub.LastUpdatedTime = DateTime.Now;

            //_context.Clubs.Update(updateClub);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> DeleteAsync(string user, string clubId)
        {
            var clubToDelete = await _context.Clubs.FirstOrDefaultAsync(c => c.ClubID == clubId);
            if (clubToDelete == null)
            {
                throw new Exception($"Club with ID ( {clubId} ) NOT FOUND");
            }

            clubToDelete.DeletedBy = user;
            clubToDelete.DeletedTime = DateTime.Now;

            return await _context.SaveChangesAsync();
        }
    }
}
