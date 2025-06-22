using static System.Formats.Asn1.AsnWriter;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ISC_BE02.Models
{
    public class Subject
    {
        [Key]
        public int Subjects_ID { get; set; }

        public string SubjectCode { get; set; }

        public string SubjectsName { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        [ForeignKey("SubjectType")]
        public int SubjectType_ID { get; set; }
        public SubjectType SubjectType { get; set; }

        [ForeignKey("Department")]
        public int Department_ID { get; set; }
        public Team_Department Department { get; set; }

        [ForeignKey("User")]
        public int User_ID { get; set; }
        public User User { get; set; }

        [ForeignKey("SchoolYear")]
        public int SchoolYear_ID { get; set; }
        public SchoolYear SchoolYear { get; set; }

        public ICollection<Subjects_Class> Subjects_Classes { get; set; }
        public ICollection<ClassHistory> ClassHistory { get; set; }
        public ICollection<PastClasses> PastClasses { get; set; }
        public ICollection<UpcomingClass> UpcomingClasses { get; set; }
        public ICollection<TeacherProfile> TeacherProfiles { get; set; }
        public ICollection<Score> Scores { get; set; }
        public ICollection<Teaching_Assessment> TeachingAssessments { get; set; }
        public ICollection<LabSchedules> LabSchedules { get; set; }
        public ICollection<Question> Questions { get; set; }
    }
}
