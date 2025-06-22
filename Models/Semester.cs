using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ISC_BE02.Models
{
    public class Semester
    {
        [Key]
        public int Semester_ID { get; set; }

        public string SemesterName { get; set; }

        public int LessonOfSemester { get; set; }

        public DateTime StartTimeSemester { get; set; }

        public DateTime EndTimeSemester { get; set; }

        public bool Is_Current { get; set; }

        [ForeignKey("SchoolYear")]
        public int SchoolYear_ID { get; set; }
        public SchoolYear SchoolYear { get; set; }
    }
}
