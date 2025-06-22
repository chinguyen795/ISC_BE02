using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ISC_BE02.Models
{
    public class Syllabus_topics
    {
        [Key]
        public int Syllabus_ID { get; set; }

        [ForeignKey("TeachingAssessment")]
        public int Teaching_ID { get; set; }
        public Teaching_Assessment TeachingAssessment { get; set; }

        public string Topic_title { get; set; }

        public int Order_index { get; set; }

        public DateTime StarTime { get; set; }

        public DateTime EndTime { get; set; }

        public string Description { get; set; }

        [ForeignKey("SchoolYear")]
        public int SchoolYear_ID { get; set; }
        public SchoolYear SchoolYear { get; set; }
    }
}
