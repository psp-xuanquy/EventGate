using EventGate.Data.Entity;
using EventGate.Data.Repositories.Interface;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Data.Repositories
{
    public class ChatRoomRepository : IChatRoomRepository
    {
        private readonly AppDbContext _appDbContext;
        public ChatRoomRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
           
        }

        public async Task<int> AddARoom(ChatRoom room)
        {
            var result = await _appDbContext.ChatRooms.FirstOrDefaultAsync(r => r.RoomName == room.RoomName  && r.DeletedTime == null);
            if (result != null)
            {
                throw new Exception("This name has been already exists, Choose another name !");
            }

            await _appDbContext.ChatRooms.AddAsync(room);
            return await _appDbContext.SaveChangesAsync();
        }

        public async Task<int> DeleteRoom(string id)
        {
            var chatRoom = await GetByIdRoom(id);
            chatRoom.DeletedTime = DateTime.Now;
            return await _appDbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<ChatRoom>> GetAllRoom()
        {
            var list = await _appDbContext.ChatRooms.Where(x => x.DeletedTime == null).AsNoTracking().ToListAsync();
            return list;
        }

        public async Task<ChatRoom> GetByIdRoom(string id)
        {
            var room = await _appDbContext.ChatRooms.Where(x => x.ChatRoomID == id && x.DeletedTime == null).FirstOrDefaultAsync();  
            if (room == null)
            {
                throw new Exception("Chat room does not exist");
            }
            return room;
        }

        public async Task<int> UpdateRoom(string id, ChatRoom chatRoom)
        {
            var ChatRoom = await GetByIdRoom(id); 
            ChatRoom.RoomName = chatRoom.RoomName;
            ChatRoom.Description = chatRoom.Description;
            ChatRoom.LastUpdatedTime = DateTime.Now;
            return await _appDbContext.SaveChangesAsync();
        }

    }
}
