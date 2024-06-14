using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventGate.Data.Entity
{
    public class Point
    {
        [Key]
        public string PointID { get; set; } = Guid.NewGuid().ToString();
        public int Points { get; set; }

        [ForeignKey("User")]
        public string? UserID { get; set; }
        public User? User { get; set; }
    }
}
