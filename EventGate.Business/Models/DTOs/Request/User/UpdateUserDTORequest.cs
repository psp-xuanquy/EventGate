using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Business.Models.DTOs.Request.User
{
    public class UpdateUserDTORequest
    {
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? IdentityCard { get; set; }
        public string? DateOfBirth { get; set; }
        public string? Avatar { get; set; }
    }
}
