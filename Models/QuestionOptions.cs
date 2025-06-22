using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ISC_BE02.Models
{
    public class QuestionOptions
    {
        [Key]
        public int QuestionOptions_ID { get; set; }

        [ForeignKey("Question")]
        public int Questions_ID { get; set; }
        public Question Question { get; set; }

        public string Option_text { get; set; }

        public bool Is_correct { get; set; }

        public ICollection<StudentMCQAnswers> StudentMCQAnswers { get; set; }
    }
}
