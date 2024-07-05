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
    public class UserEventHistoryRepository : IUserEventHistoryRepository
    {
        private readonly AppDbContext _appDbContext;

        public UserEventHistoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
 
        public async Task<List<UserEventHistory>> GetAllAsync()
        {
            var list = await _appDbContext.UserEventHistories.ToListAsync();
            return list;
        }
        public async Task<int> AddUserEventHistoryAsync(UserEventHistory userEventHistory)
        {

            _appDbContext.UserEventHistories.Add(userEventHistory);
            return await _appDbContext.SaveChangesAsync();
        }
    }
}
