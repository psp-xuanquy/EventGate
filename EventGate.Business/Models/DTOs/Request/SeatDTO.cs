using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Business.Models.DTOs.Request
{
    public class SeatDTO
    {
        public string SeatID { get; set; }

        public string Hall { get; set; }

        public string Row { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Number must be greater than zero")]
        public int Number { get; set; }

        public bool IsAvailable { get; set; }
    }

}
