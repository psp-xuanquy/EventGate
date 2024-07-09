using EventGate.Data.Entities;
using EventGate.Data.Entity;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;

namespace EventGate.Data.Repositories
{
    public class ChatRepository : Hub
    {
        private readonly AppDbContext _appDbContext;

        public ChatRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<bool> IsUserInGroup(string userId, string chatRoomId)
        {
            var userInGroup = await _appDbContext.UserChatRooms
                .AnyAsync(x => x.ChatRoomID == chatRoomId && x.UserID == userId && x.DeletedTime == null);
            return userInGroup;
        }

        public async Task JoinChat(UserChatRoom chat)
        {
            await Clients.All.SendAsync("ReceiveMessage", "admin", $"{chat.UserID} has Joined");
        }

        public async Task AddToGroup(UserChatRoom chat)
        {
            var UserName = await _appDbContext.Users.FirstOrDefaultAsync(x => x.Id == chat.UserID);
            var ChatRoomName = await _appDbContext.ChatRooms.FirstOrDefaultAsync(x => x.ChatRoomID == chat.ChatRoomID && x.DeletedTime == null);

            var AddCheck = await _appDbContext.UserChatRooms.FirstOrDefaultAsync(x => x.ChatRoomID == chat.ChatRoomID && x.UserID == chat.UserID && x.DeletedTime == null);
            if (AddCheck == null)
            {
                await Groups.AddToGroupAsync(Context.ConnectionId, chat.ChatRoomID);
                await Clients.Group(chat.ChatRoomID!).SendAsync("ReceiveMessage", "admin", $"{UserName.UserName} has Join the Group !");
                UserChatRoom Chat = new UserChatRoom
                {
                    UserID = chat.UserID,
                    ChatRoomID = chat.ChatRoomID,
                };
                await _appDbContext.UserChatRooms.AddAsync(Chat);
                await _appDbContext.SaveChangesAsync();
            }
            else
            {
                throw new Exception("User already exists in this room");
            }
        }

        public async Task Chat(UserChatRoom chatRoom, string message)
        {
            var user = await _appDbContext.Users.FirstOrDefaultAsync(x => x.Id == chatRoom.UserID);
            var check = await _appDbContext.UserChatRooms.FirstOrDefaultAsync(x => x.ChatRoomID == chatRoom.ChatRoomID && x.UserID == chatRoom.UserID && x.DeletedTime == null);

            if (check != null)
            {
                await Clients.Group(chatRoom.ChatRoomID).SendAsync("ReceiveMessage", user.UserName, message);

                var chatMessage = new Chat
                {
                    Message = message,
                    SenderID = chatRoom.UserID,
                    ChatRoomID = chatRoom.ChatRoomID,
                    CreatedTime = DateTime.Now,
                };

                await _appDbContext.Chats.AddAsync(chatMessage);
                await _appDbContext.SaveChangesAsync();
            }
            else
            {
                throw new Exception("User is not part of this chat room.");
            }
        }
    }
}
