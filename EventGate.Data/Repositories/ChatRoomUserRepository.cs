using EventGate.Data.Entities;
using EventGate.Data.Entity;
using EventGate.Data.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Data.Repositories
{
    public class ChatRoomUserRepository : IUserChatRepository
    {
        private readonly AppDbContext _context;
        public ChatRoomUserRepository(AppDbContext dbContext)
        {
            _context = dbContext;
        }

        public async Task<int> AddUsertoRoom(string chatroomId, string userId)
        {
            var AddCheck = await _context.UserChatRooms.FirstOrDefaultAsync(x => x.ChatRoomID == chatroomId && x.UserID == userId && x.DeletedTime == null);
            if (AddCheck == null)
            {
                UserChatRoom Chat = new UserChatRoom
                {
                    ChatRoomID = chatroomId,
                    UserID = userId
                };
                await _context.UserChatRooms.AddAsync(Chat);
            }
            else
            {
                throw new Exception("User has been exist in this room");
            }
            return await _context.SaveChangesAsync();
        }

        public async Task<int> DeleteUseroutofRoom(string chatromId, string userId)
        {
            var DeleteCheck = await _context.UserChatRooms.FirstOrDefaultAsync(x => x.ChatRoomID == chatromId && x.UserID == userId);
            if (DeleteCheck != null)
            {
                DeleteCheck.DeletedTime = DateTime.Now;            
            }
            else
            {
                throw new Exception("User was deleted or not exist here !");             
            }
            return await _context.SaveChangesAsync();
        }
    }
}
