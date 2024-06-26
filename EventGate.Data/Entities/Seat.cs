using EventGate.Data.Entities;
using System.ComponentModel.DataAnnotations;

namespace EventGate.Data.Entity
{
    public class Seat : AbstractEntity
    {
        [Key]
        public string SeatID { get; set; } = Guid.NewGuid().ToString();
        public string? Hall {  get; set; }
        public string? Row { get; set; }
        public int Number { get; set; }
        public bool IsAvailable { get; set; }
    }
}
