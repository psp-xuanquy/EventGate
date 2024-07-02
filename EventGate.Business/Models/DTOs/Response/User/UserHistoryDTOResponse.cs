using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Business.Models.DTOs.Response.User
{
    public class UserHistoryDTOResponse
    {
        public string? UserName { get; set; }
        public string? Avatar { get; set; }
        public string? Mail { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? IdentityCard { get; set; }
        public string? DateOfBirth { get; set; }
        public string? ArchivedDate { get; set; }
        public string? UserID { get; set; }
    }
}
