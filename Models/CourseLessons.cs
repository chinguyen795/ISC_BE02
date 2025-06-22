using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ISC_BE02.Models
{
    public enum CourseLessonStatus
    {
        Scheduled,
        Completed,
        Cancelled
    }
    public class CourseLessons
    {
        [Key]
        public int CourseLessons_ID { get; set; }

        public string Title { get; set; }

        public DateTime LessonTime { get; set; }

        public string RoomNumber { get; set; }

        public CourseLessonStatus Status { get; set; } // Using an enum

        [ForeignKey("CourseOffering")]
        public int CourseOfferings_ID { get; set; }
        public CourseOfferings CourseOffering { get; set; }

        [ForeignKey("School")]
        public int School_ID { get; set; }
        public SchoolProfile School { get; set; }
    }
}
