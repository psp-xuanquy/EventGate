using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Business.Models.DTOs.Request
{
    public class ClubDTO
    {
        //public string ClubID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string? Name { get; set; }

        [Display(Name = "Member Quantity")]
        public int? MemberQuantity { get; set; }

        [Display(Name = "Logo Club")]
        public string? LogoClub { get; set; }

        public string? Description { get; set; }

        public string? PresidentID { get; set; }
    }
}
