using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ISC_BE02.Models
{
    public class CoursesLearned
    {
        [Key]
        public int CoursesLearned_ID { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Syllabus { get; set; }

        [Column(TypeName = "decimal(12, 2)")]
        public decimal Default_price { get; set; }

        public string Courses_image_url { get; set; }

        [ForeignKey("TotalCourses")]
        public int TotalCourses_ID { get; set; }
        public TotalCoursesTaken TotalCourses { get; set; }

        [ForeignKey("SchoolYear")]
        public int SchoolYear_ID { get; set; }
        public SchoolYear SchoolYear { get; set; }
    }
}
