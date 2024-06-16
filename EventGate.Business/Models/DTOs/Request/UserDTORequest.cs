using EventGate.Data.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Data.DTOs.Request
{
    public class UserDTORequest
    {
        public string UserName {  get; set; }
        public string Password { get; set; }
        public string? Avatar { get; set; }
        public string? Address { get; set; }
        public string? IdentityCard { get; set; }
        public DateTime? DateOfBirth { get; set; }
    }
}
