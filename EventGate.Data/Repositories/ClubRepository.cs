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

        // Get All Club
        public async Task<List<Club>> GetAllAsync()
        {
            return await _context.Clubs
                .Where(c => c.DeletedTime == null)
                .Include(c => c.President)
                .ToListAsync();
        }

        // Get Club By ID
        public async Task<Club> GetByIdAsync(string clubId)
        {
            return await _context.Clubs
                .Where(c => c.DeletedTime == null)
                .Include(c => c.President)
                .FirstOrDefaultAsync(c => c.ClubID == clubId);
        }

        // Get Club By Name
        public async Task<Club> GetByNameAsync(string clubName)
        {
            return await _context.Clubs.FirstOrDefaultAsync(c => c.Name == clubName && c.DeletedTime == null)!;
        }

        // Add Club 
        public async Task<int> AddAsync(string user, Club addClub)
        {
            addClub.CreatedBy = user;
            addClub.LastUpdatedBy = user;
            addClub.LastUpdatedTime = DateTime.Now;

            await _context.Clubs.AddAsync(addClub);
            return await _context.SaveChangesAsync();
        }

        // Update Club
        public async Task<int> UpdateAsync(string user, string clubId, Club updateClub)
        {
            var existingClub = await _context.Clubs.FirstOrDefaultAsync(c => c.ClubID == clubId && c.DeletedTime == null);

            existingClub.Name = updateClub.Name;
            existingClub.MemberQuantity = updateClub.MemberQuantity;
            existingClub.LogoClub = updateClub.LogoClub;
            existingClub.Description = updateClub.Description;
            existingClub.PresidentID = updateClub.PresidentID;
            existingClub.LastUpdatedBy = user;
            existingClub.LastUpdatedTime = DateTime.Now;

            return await _context.SaveChangesAsync();
        }

        // Delete Club
        public async Task<int> DeleteAsync(string user, string clubId)
        {
            var clubToDelete = await _context.Clubs.FirstOrDefaultAsync(c => c.ClubID == clubId && c.DeletedTime == null);

            clubToDelete.DeletedBy = user;
            clubToDelete.DeletedTime = DateTime.Now;

            return await _context.SaveChangesAsync();
        }
    }
}
