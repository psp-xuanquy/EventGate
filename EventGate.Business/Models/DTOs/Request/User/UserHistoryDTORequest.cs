using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Business.Models.DTOs.Request.User
{
    public class UserHistoryDTORequest
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string? Avatar { get; set; }
        public string? Mail { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? IdentityCard { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public DateTime? ArchivedDate { get; set; }
        public string? UserID { get; set; }
    }
}
