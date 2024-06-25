
using EventGate.Data.Entity;
using EventGate.Data.Repositories.Interface;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace EventGate.Data.Repositories
{
    public class UserRepository : IUserPropository
    {
        private readonly AppDbContext _appDbContext;

        public UserRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<int> AddAsync(User user)
        {
            var result = await _appDbContext.Users.FirstOrDefaultAsync(u => u.UserName == user.UserName || u.Email == user.Email && u.DeletedTime == null);
            if (result != null)
            {
                throw new Exception("User already exists");
            }

            await _appDbContext.Users.AddAsync(user);
            return await _appDbContext.SaveChangesAsync();
        }

        public async Task<int> DeleteAsync(Guid id)
        {
            var user = await _appDbContext.Users.Where(x => x.Id.Equals(id) && x.DeletedTime == null).SingleOrDefaultAsync();
            if (user != null)
            {
                throw new Exception("User does not exist");
            }
            _appDbContext.Users.Remove(user);
            return await _appDbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            var list = await _appDbContext.Users.Where(x => x.DeletedTime == null).AsNoTracking().ToListAsync();
            return list;
        }

        public async Task<User> GetByIdAsync(Guid id)
        {
            var user = await _appDbContext.Users.Where(x => x.Id.Equals(id) && x.DeletedTime == null).SingleOrDefaultAsync();
            if(user == null)
                throw new Exception("User does not exist");
            return user;
        }

        public async Task<int> UpdateAsync(User user)
        {
            var newUser = await _appDbContext.Users.Where(x => x.Id.Equals(user.Id) && x.DeletedTime == null).SingleOrDefaultAsync();
            if (newUser == null)
            {
                throw new Exception("User does not exist");
            }
            _appDbContext.Users.Update(user);
            return await _appDbContext.SaveChangesAsync();
        }

        public async Task<User> VerifyLoginAsync(string userName, string password)
        {
            var user = await _appDbContext.Users.SingleOrDefaultAsync(u => u.UserName == userName && u.DeletedTime == null);
            if (user == null || !VerifyPassword(user, password))
            {
                return null;
            }
            return user;
        }

        private bool VerifyPassword(User user, string password)
        {
            var passwordHasher = new PasswordHasher<User>();
            var result = passwordHasher.VerifyHashedPassword(user, user.PasswordHash, password);
            return result == PasswordVerificationResult.Success;
        }
    }
}
