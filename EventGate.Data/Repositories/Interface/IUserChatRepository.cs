using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Data.Repositories.Interface
{
    public interface IUserChatRepository
    {
        Task<int> AddUsertoRoom(string chatroomId, string userId);


    }
}
