using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ISC_BE02.Models
{
    public class Course
    {
        [Key]
        public int Courses_ID { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Syllabus { get; set; }

        [Column(TypeName = "decimal(12, 2)")]
        public decimal Default_price { get; set; }

        public string Courses_image_url { get; set; }

        [ForeignKey("CourseCategory")]
        public int CourseCategories_ID { get; set; }
        public CourseCategories CourseCategory { get; set; }

        public ICollection<CourseOfferings> CourseOfferings { get; set; }
    }
}
