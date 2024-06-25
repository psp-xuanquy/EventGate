using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Business.Models.DTOs.Request
{
    public class OrderDTO
    {
        public string OrderID { get; set; }

        [Display(Name = "Order Date")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = false)]
        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }

        [Display(Name = "Payment Method")]
        public string PaymentMethod { get; set; }

        public bool Status { get; set; }

        [Display(Name = "Total Price")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Total price must be greater than zero")]
        public decimal TotalPrice { get; set; }

        public string UserID { get; set; }
    }
}
