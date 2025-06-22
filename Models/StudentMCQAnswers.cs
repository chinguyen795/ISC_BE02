using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ISC_BE02.Models
{
    public class StudentMCQAnswers
    {
        [Key]
        public int StudentMCQAnswers_ID { get; set; }

        [ForeignKey("Submission")]
        public int Submissions_ID { get; set; }
        public Student_Submissions Submission { get; set; }

        [ForeignKey("Question")]
        public int Questions_ID { get; set; }
        public Question Question { get; set; }

        [ForeignKey("QuestionOption")]
        public int QuestionOptions_ID { get; set; }
        public QuestionOptions QuestionOption { get; set; }
    }
}
