using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ISC_BE02.Models
{
    public enum AssignmentFormat
    {
        File,
        Text,
        Quiz
    }

    public enum AssignmentScope
    {
        Individual,
        Group
    }

    public enum AssignmentStatus
    {
        Published,
        Draft,
        Archived
    }

    public enum PartitionType
    {
        Chapter,
        Module,
        Lesson
    }

    public class Assignment
    {
        [Key]
        public int Assignment_ID { get; set; }

        public string Title { get; set; }

        public AssignmentFormat Format { get; set; } // Using an enum

        public AssignmentScope Assignment_scope { get; set; } // Using an enum

        public string Category { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public string Assignment_Url { get; set; }

        public string Description { get; set; }

        public AssignmentStatus Status { get; set; } // Using an enum

        public PartitionType PartitionType { get; set; } // Using an enum

        public DateTime CraeteAt { get; set; }

        [ForeignKey("TeachingAssessment")]
        public int Teaching_ID { get; set; }
        public Teaching_Assessment TeachingAssessment { get; set; }

        [ForeignKey("Faculty")]
        public int Faculty_ID { get; set; }
        public Faculty_StudyBlock Faculty { get; set; }

        public ICollection<AssessmentParts> AssessmentParts { get; set; }
        public ICollection<Assignment_Group> Assignment_Groups { get; set; }
    }
}
