using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ISC_BE02.Models
{
    public enum ScoreCoefficientType
    {
        Midterm,
        Final,
        Quiz
    }

    public enum ScoreSemesterType
    {
        Semester1,
        Semester2,
        Summer
    }
    public class Score
    {
        [Key]
        public int Score_ID { get; set; }

        public string ScoreType { get; set; }

        public ScoreCoefficientType Coefficient { get; set; } // Using an enum

        public int ScoreNumber { get; set; }

        public int AverageScore { get; set; }

        public ScoreSemesterType Semester { get; set; } // Using an enum

        [ForeignKey("Subject")]
        public int Subjects_ID { get; set; }
        public Subject Subject { get; set; }

        [ForeignKey("Class")]
        public int Class_ID { get; set; }
        public Class Class { get; set; }

        [ForeignKey("SchoolYear")]
        public int SchoolYear_ID { get; set; }
        public SchoolYear SchoolYear { get; set; }

        public ICollection<LearningOutcomes> LearningOutcomes { get; set; }
    }
}
