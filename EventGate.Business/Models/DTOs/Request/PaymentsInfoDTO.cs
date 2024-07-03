using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Business.Models.DTOs.Request
{
    public class PaymentsInfoDTO
    {
        public string? AccountHolderName { get; set; }
        public string? AccountNumber { get; set; }
        public string? BankName { get; set; }
        public string? BankBranch { get; set; }
        public decimal TotalPayments { get; set; }
        public DateTime ValidDate { get; set; }
        public string? EventID { get; set; }
    }
}
