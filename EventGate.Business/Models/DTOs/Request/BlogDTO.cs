using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Business.Models.DTOs.Request
{
    public class BlogDTO
    {
        public string? Image { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public string? EventID { get; set; }
        public string? AuthorID { get; set; }
    }
}
