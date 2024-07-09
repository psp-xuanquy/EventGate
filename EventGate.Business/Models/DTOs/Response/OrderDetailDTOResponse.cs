using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Business.Models.DTOs.Response
{
    public class OrderDetailDTOResponse
    {
        //public string OrderDetailID { get; set; }

        public string OrderID { get; set; }
        public int Quantity { get; set; }
        public string TicketID { get; set; }
    }
}
