using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ISC_BE02.Models
{
    public enum UpcomingClassStatus
    {
        Scheduled,
        Delayed,
        Cancelled
    }
    public class UpcomingClass
    {
        [Key]
        public int ClassID { get; set; } // Assuming this is a primary key for UpcomingClass, distinct from Class_ID

        public DateTime StartTime { get; set; }

        public UpcomingClassStatus Status { get; set; } // Using an enum

        [ForeignKey("Subject")]
        public int Subject_ID { get; set; }
        public Subject Subject { get; set; }

        [ForeignKey("User")]
        public int User_ID { get; set; }
        public User User { get; set; }
    }
}
