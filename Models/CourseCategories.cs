using System.ComponentModel.DataAnnotations;

namespace ISC_BE02.Models
{
    public class CourseCategories
    {
        [Key]
        public int CourseCategories_ID { get; set; }

        public string CourseCategoriesName { get; set; }

        public string Description { get; set; }

        public ICollection<Course> Courses { get; set; }
    }
}
