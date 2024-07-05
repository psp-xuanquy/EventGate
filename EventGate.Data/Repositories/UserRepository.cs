
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

        //Get All User
        public async Task<List<User>> GetAllAsync()
        {
            var list = await _appDbContext.Users.Where(x => x.DeletedTime == null).AsNoTracking().ToListAsync();
            return list;
        }


        //Get User By Id
        public async Task<User> GetByIdAsync(string id)
        {
            var user = await _appDbContext.Users
                .Where(user => user.DeletedTime == null)
                .FirstOrDefaultAsync(user => user.Id == id);
            return user;
        }


        //Update User
        public async Task<int> UpdateAsync(string id, User user)
        {
            var existUser = await _appDbContext.Users
                .Where(user => user.DeletedTime == null)
                .FirstOrDefaultAsync(user => user.Id == id);
            if (existUser == null)
            {
                throw new Exception("User does not exist");
            }
            _appDbContext.Users.Update(user);
            return await _appDbContext.SaveChangesAsync();
        }

        public async Task<int> DeleteAsync(User user)
        {
            _appDbContext.Users.Remove(user);
            return await _appDbContext.SaveChangesAsync();
        }

        //Verify Login
        public async Task<User> VerifyLoginAsync(string userName, string password)
        {
            var user = await _appDbContext.Users.SingleOrDefaultAsync(u => u.UserName == userName || u.Email == userName && u.DeletedTime == null);
            if (user == null || !VerifyPassword(user, password))
            {
                return null;
            }
            return user;
        }

        //Verify Password
        private bool VerifyPassword(User user, string password)
        {
            var passwordHasher = new PasswordHasher<User>();
            var result = passwordHasher.VerifyHashedPassword(user, user.PasswordHash, password);
            return result == PasswordVerificationResult.Success;
        }

        public async Task<User> GetUserByEmail(string email)
        {
            var user = await _appDbContext.Users
                .Where(user => user.DeletedTime == null)
                .FirstOrDefaultAsync(user => user.Email == email);

            return user;
        }
    }
}
