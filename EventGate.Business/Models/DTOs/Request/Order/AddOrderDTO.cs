using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Business.Models.DTOs.Request.Order
{
    public class AddOrderDTO
    {
        [Display(Name = "Payment Method")]
        [Required(ErrorMessage = "Payment Method is required")]
        public string PaymentMethod { get; set; }

        public bool Status { get; set; }

        [Required(ErrorMessage = "UserID is required")]
        public string UserID { get; set; }

        public List<OrderDetailDTO> OrderDetails { get; set; }
    }
}
