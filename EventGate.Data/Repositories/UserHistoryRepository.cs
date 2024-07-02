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
    public class UserHistoryRepository : IUserHistoryRepository
    {
        private readonly AppDbContext _appDbContext;

        public UserHistoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<UserHistory>> GetAllAsync()
        {
            var list = await _appDbContext.UserHistories.ToListAsync();
            return list;
        }
        public async Task<int> AddUserHistoryAsync(UserHistory userHistory)
        {
            _appDbContext.UserHistories.Add(userHistory);
            return await _appDbContext.SaveChangesAsync();
        }

    }
}
