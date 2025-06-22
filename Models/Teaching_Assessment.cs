using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ISC_BE02.Models
{
    public enum AssignmentType
    {
        Homework,
        Quiz,
        Exam,
        Project
    }
    public class Teaching_Assessment
    {
        [Key]
        public int Teaching_ID { get; set; }

        public AssignmentType AssignmentType { get; set; } // Using an enum

        public int Semester { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public string Description { get; set; }

        [ForeignKey("Class")]
        public int Class_ID { get; set; }
        public Class Class { get; set; }

        [ForeignKey("Subject")]
        public int Subject_ID { get; set; }
        public Subject Subject { get; set; }

        [ForeignKey("User")]
        public int User_ID { get; set; }
        public User User { get; set; }

        [ForeignKey("SchoolYear")]
        public int SchoolYear_ID { get; set; }
        public SchoolYear SchoolYear { get; set; }

        public ICollection<AssessmentParts> AssessmentParts { get; set; }
        public ICollection<Assignment> Assignments { get; set; }
        public ICollection<Syllabus_topics> SyllabusTopics { get; set; }
        public ICollection<LiveSessions> LiveSessions { get; set; }
        public ICollection<DiscussionThreads> DiscussionThreads { get; set; }
    }
}
