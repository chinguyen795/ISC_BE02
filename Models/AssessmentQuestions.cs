using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ISC_BE02.Models
{
    public class AssessmentQuestions
    {
        [Key]
        public int AssessmentQuestions_ID { get; set; }

        public int Question_order { get; set; }

        [ForeignKey("Question")]
        public int Questions_ID { get; set; }
        public Question Question { get; set; }
    }
}
