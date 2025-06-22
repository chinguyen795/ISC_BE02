using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ISC_BE02.Models
{
    public class Student_Submissions
    {
        [Key]
        public int Submissions_ID { get; set; }

        public DateTime Submission_time { get; set; }

        public string File_url { get; set; }

        public string Notes { get; set; }

        public string Text_answer { get; set; }

        [ForeignKey("AssessmentPart")]
        public int AssessmentParts_ID { get; set; }
        public AssessmentParts AssessmentPart { get; set; }

        [ForeignKey("User")]
        public int User_ID { get; set; }
        public User User { get; set; }

        [ForeignKey("SchoolYear")]
        public int SchoolYear_ID { get; set; }
        public SchoolYear SchoolYear { get; set; }

        public ICollection<StudentMCQAnswers> StudentMCQAnswers { get; set; }
    }
}
