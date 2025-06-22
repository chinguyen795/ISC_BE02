using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ISC_BE02.Models
{
    public enum QuestionsType
    {
        MultipleChoice,
        TrueFalse,
        ShortAnswer,
        Essay
    }
    public class Question
    {
        [Key]
        public int Questions_ID { get; set; }

        public DateTime Questions_Text { get; set; } // This is likely a string, not DateTime

        public QuestionsType QuestionsType { get; set; } // Using an enum

        [ForeignKey("User")]
        public int User_ID { get; set; }
        public User User { get; set; }

        [ForeignKey("Subject")]
        public int Subject_ID { get; set; }
        public Subject Subject { get; set; }

        public ICollection<StudentMCQAnswers> StudentMCQAnswers { get; set; }
        public ICollection<QuestionOptions> QuestionOptions { get; set; }
        public ICollection<AssessmentQuestions> AssessmentQuestions { get; set; }
    }
}
