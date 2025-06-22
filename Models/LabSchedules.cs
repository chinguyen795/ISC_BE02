using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ISC_BE02.Models
{
    public enum TermNumber
    {
        Term1,
        Term2,
        Term3
    }

    public enum LabScheduleStatus
    {
        Scheduled,
        Completed,
        Cancelled
    }
    public class LabSchedules
    {
        [Key]
        public int LabSchedules_ID { get; set; }

        public TermNumber Term_number { get; set; } // Using an enum

        public string Lab_name { get; set; }

        public DateTime Lab_start_date { get; set; }

        public DateTime Lab_end_date { get; set; }

        public int Duration_minutes { get; set; }

        public LabScheduleStatus Status { get; set; } // Using an enum

        [ForeignKey("Subject")]
        public int Subject_ID { get; set; }
        public Subject Subject { get; set; }

        [ForeignKey("User")]
        public int User_ID { get; set; }
        public User User { get; set; }

        [ForeignKey("SchoolYear")]
        public int SchoolYear_ID { get; set; }
        public SchoolYear SchoolYear { get; set; }

        public ICollection<LabScheduleClasses> LabScheduleClasses { get; set; }
        public ICollection<LabGraders> LabGraders { get; set; }
    }
}
