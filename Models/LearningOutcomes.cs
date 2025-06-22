using static System.Formats.Asn1.AsnWriter;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ISC_BE02.Models
{
    public class LearningOutcomes
    {
        [Key]
        public int LearningOutcomes_ID { get; set; } // Renamed from 'LearningOutcomes' column name

        public string Conduct { get; set; }

        public int Average_score { get; set; }

        public bool AcademicPerformance { get; set; }

        public DateTime UpdateAt { get; set; }

        [ForeignKey("Score")]
        public int Score_ID { get; set; }
        public Score Score { get; set; }

        [ForeignKey("User")]
        public int User_ID { get; set; }
        public User User { get; set; }

        [ForeignKey("SchoolYear")]
        public int SchoolYear_ID { get; set; }
        public SchoolYear SchoolYear { get; set; }
    }
}
