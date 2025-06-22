using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ISC_BE02.Models
{
    public class AssessmentParts
    {
        [Key]
        public int AssessmentParts_ID { get; set; }

        public int Part_order { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Assignment_url { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        [ForeignKey("Assignment")]
        public int Assignment_ID { get; set; }
        public Assignment Assignment { get; set; }

        public ICollection<Student_Submissions> StudentSubmissions { get; set; }
    }
}
