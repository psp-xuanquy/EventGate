using EventGate.Data.Entities;
using EventGate.Data.Entity;
using EventGate.Data.Repositories.Interface;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EventGate.Data.Repositories
{
   public class ChatRepository: Hub, IChatRepository

    {
        private readonly AppDbContext _appDbContext;
        public ChatRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<int> AddUsertoRoom(string UserID, string ChatRoomID)
        {
            var UserName = await _appDbContext.Users.FirstOrDefaultAsync(x => x.Id == UserID);
            var ChatRoomName = await _appDbContext.ChatRooms.FirstOrDefaultAsync(x => x.ChatRoomID ==ChatRoomID && x.DeletedTime == null);

            var AddCheck = await _appDbContext.UserChatRooms.FirstOrDefaultAsync(x => x.ChatRoomID == ChatRoomID && x.UserID == UserID && x.DeletedTime == null);
            if (AddCheck == null)
            {
                UserChatRoom Chat = new UserChatRoom 
                { 
                    UserID = UserID,
                    ChatRoomID = ChatRoomID,
                };
                await _appDbContext.UserChatRooms.AddAsync(Chat);
                await _appDbContext.SaveChangesAsync();
                await Groups.AddToGroupAsync(Context.ConnectionId, ChatRoomID);
                await Clients.Group(ChatRoomID).SendAsync("admin", $"{UserName.UserName} has joined Group Chat {ChatRoomName.RoomName}");
                return 1; 
            }
            else
            {
                throw new Exception("User already exists in this room");
            }
        }

        public async Task<int> Chat(string Message, string idUser, string idChatRoom)
        {
            var check = await _appDbContext.UserChatRooms.FirstOrDefaultAsync(x => x.ChatRoomID == idChatRoom && x.UserID == idUser && x.DeletedTime == null);
            if (check == null)
            {
                throw new Exception("Add user to chat room Pls!");
            }
            Chat chat = new Chat
            {
                Message = Message,
                SenderID = idUser,
                ChatRoomID = idChatRoom,
                CreatedTime = DateTime.Now,
            };
            await _appDbContext.Chats.AddAsync(chat);
            await Clients.Group(idChatRoom).SendAsync(idUser, Message);
            return await _appDbContext.SaveChangesAsync();
        }
    }



    /*     public async Task<int> MarkAsRead(string messageId, string userId)
         {
             var chat = await _appDbContext.Chats.FirstOrDefaultAsync(x => x.ChatID == messageId && x.IsDeleted == false); 
             if(chat != null)
             {
                 var messageReceipt = await _appDbContext.ChatReceivers
                 .FirstOrDefaultAsync(r => r.ChatID == messageId && r.ReceiverID == userId);
                 if (messageReceipt != null)
                 {
                    messageReceipt.ChatID= messageId;
                    messageReceipt.ReceiverID = userId;
                 }
             }
             else 
             {
                 throw new Exception("Can't find this chat");
             }

             await Clients.Group((await _appDbContext.Chats.FindAsync(messageId)).ChatRoomID.ToString())
                 .SendAsync("MessageRead", messageId, userId);
            return await _appDbContext.SaveChangesAsync();  
         }*/

}
