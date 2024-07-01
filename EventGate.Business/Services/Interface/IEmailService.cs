using EventGate.Business.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Business.Services.Interface
{
    public interface IEmailService
    {
        void SendEmail(Message message);
        string GetEmailTemplate(string template);
        Task<ServiceResult<string>> SendConfirmEmailAsync(string email);
    }
}
