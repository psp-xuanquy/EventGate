using EventGate.Data.Entity;
using EventGate.Data.Repositories.Interface;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Data.Repositories
{
   public class ChatRepository: IChatRepository
    {
        private readonly AppDbContext _appDbContext;
        public ChatRepository(AppDbContext appDbContext)
        {
                _appDbContext = appDbContext;

        }

        public async Task<IEnumerable<Chat>> GetAllChat(string idchatRom)
        {
              var list = await _appDbContext.Chats.Where(x => x.ChatRoomID == idchatRom &&  x.DeletedTime == null ).AsNoTracking().ToListAsync();
              return list;
         }
   }
}



