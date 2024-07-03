using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Business.Models.DTOs.Request.User
{
    public class UserEventHistoryDTORequest
    {
        public string? UserEventID { get; set; }
        public string? EventID { get; set; }
        public string? UserID { get; set; }

        public DateTime ArchiveDate { get; set; }
    }
}
