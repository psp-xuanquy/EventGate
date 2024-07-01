using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Business.Models.DTOs.Request
{
    public class TicketDTO
    {
        //public string TicketID { get; set; }

        public string Gate { get; set; }

        //public byte[] QRCode { get; set; }
        public string? QRCodeBase64 { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than zero")]
        [Required(ErrorMessage = "Price is required")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Expiration Date is required")]
        [Display(Name = "Expiration Date")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = false)]
        [DataType(DataType.Date)]
        public DateTime ExpirationDate { get; set; }

        public bool IsUsed { get; set; }

        [Required(ErrorMessage = "SeatID is required")]
        public string SeatID { get; set; }

        [Required(ErrorMessage = "EventID is required")]
        public string EventID { get; set; }
    }
}
