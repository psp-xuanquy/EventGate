using EventGate.Business.Models.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Business.Models.DTOs.Request
{
    public class VoucherDTO
    {
        public string VoucherID { get; set; }

        public string Code { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be greater than zero")]
        public int Quantity { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "Discount must be greater than zero")]
        public decimal Discount { get; set; }

        [Required(ErrorMessage = "Valid Date is required")]
        [Display(Name = "Valid Date")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = false)]
        [DataType(DataType.Date)]
        public DateTime ValidDate { get; set; }

        [Required(ErrorMessage = "Expiration Date is required")]
        [Display(Name = "Expiration Date")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = false)]
        [DataType(DataType.Date)]
        [DateRange("ValidDate", ErrorMessage = "Expiration Date must be after Valid Date.")]
        public DateTime ExpirationDate { get; set; }

        public bool IsActive { get; set; }

        public string UserID { get; set; }

        public string EventID { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (ExpirationDate < ValidDate)
            {
                yield return new ValidationResult("Expiration Date must be after Valid Date", new[] { nameof(ExpirationDate) });
            }
        }
    }
}
