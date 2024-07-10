using EventGate.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Business.Services.Interface
{
    public interface IChatService
    {
        Task<ServiceResult<IEnumerable<Chat>>> GetAllAsync(string idchatroom);
    }
}
