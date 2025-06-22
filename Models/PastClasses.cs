using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ISC_BE02.Models
{
    public class PastClasses
    {
        [Key]
        public int ClassID { get; set; } // Assuming this is a primary key for PastClasses, distinct from Class_ID

        public DateTime StartTime { get; set; }

        [ForeignKey("User")]
        public int User_ID { get; set; }
        public User User { get; set; }

        [ForeignKey("Subject")]
        public int Subject_ID { get; set; }
        public Subject Subject { get; set; }
    }
}
