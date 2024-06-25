using EventGate.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Data.Repositories.Interface
{
    public interface IClubRepository
    {
        Task<List<Club>> GetAllAsync();
        Task<Club> GetByIdAsync(string clubId);
        Task<int> AddAsync(Club addClub);
        Task<int> UpdateAsync(string clubId, Club updateClub);
        Task<int> DeleteAsync(string clubId);
    }
}
