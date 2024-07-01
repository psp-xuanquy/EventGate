using EventGate.Business.Models.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Business.Models.DTOs.Request
{
    public class VoucherDTO : IValidatableObject
    {
        //public string VoucherID { get; set; }

        [Required(ErrorMessage = "Code is required")]
        public string Code { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be greater than 0")]
        [Required(ErrorMessage = "Quantity is required")]
        public int Quantity { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "Discount must be greater than 0")]
        [Required(ErrorMessage = "Discount is required")]
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
        public DateTime ExpirationDate { get; set; }

        public bool IsActive { get; set; }

        [Required(ErrorMessage = "UserID is required")]
        public string UserID { get; set; }

        [Required(ErrorMessage = "EventID is required")]
        public string EventID { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (ExpirationDate < ValidDate)
            {
                yield return new ValidationResult("Expiration Date must be AFTER Valid Date", new[] { nameof(ExpirationDate) });
            }
        }
    }
}
