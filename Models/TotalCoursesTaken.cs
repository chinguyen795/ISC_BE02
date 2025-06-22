using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ISC_BE02.Models
{
    public class TotalCoursesTaken
    {
        [Key]
        public int TotalCourses_ID { get; set; }

        public int TotalNumberCourses { get; set; }

        [Column(TypeName = "decimal(12, 2)")]
        public decimal TotalPayment { get; set; }

        [ForeignKey("CoursesLearned")]  
        public int CoursesLearned_ID { get; set; }
        public CoursesLearned CoursesLearned { get; set; }

        [ForeignKey("User")]
        public int User_ID { get; set; }
        public User User { get; set; }
    }
}
