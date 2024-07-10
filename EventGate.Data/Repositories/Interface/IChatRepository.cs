using EventGate.Data.Entities;
using EventGate.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Data.Repositories.Interface
{
    public interface IChatRepository
    {
        Task<IEnumerable<Chat>> GetAllChat(string idchatRom);
    }
}
