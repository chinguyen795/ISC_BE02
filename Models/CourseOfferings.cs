using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ISC_BE02.Models
{
    public enum CourseOfferingStatus
    {
        Open,
        Closed,
        Full,
        Cancelled
    }
    public class CourseOfferings
    {
        [Key]
        public int CourseOfferings_ID { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public int MaxStudent { get; set; }

        [Column(TypeName = "decimal(12, 2)")]
        public decimal Price { get; set; }

        public CourseOfferingStatus Status { get; set; } // Using an enum

        [ForeignKey("Course")]
        public int Courses_ID { get; set; }
        public Course Course { get; set; }
        public ICollection<Registrations> Registrations { get; set; }
        public ICollection<CourseLessons> CourseLessons { get; set; }

        [ForeignKey("InstructorUser")]
        public int Instructor_user_id { get; set; }
        public User InstructorUser { get; set; }
    }
}
