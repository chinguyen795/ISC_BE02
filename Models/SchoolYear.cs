using static System.Formats.Asn1.AsnWriter;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace ISC_BE02.Models
{
    public class SchoolYear
    {
        [Key]
        public int SchoolYear_ID { get; set; }

        public string SchoolYearName { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        [ForeignKey("User")]
        public int User_ID { get; set; }
        public User User { get; set; }
        public ICollection<User> Users { get; set; } // Users created/associated with this school year
        public ICollection<CoursesLearned> CoursesLearned { get; set; }
        public ICollection<Semester> Semesters { get; set; }
        public ICollection<StudentsChangeSchool> StudentsChangeSchoolRequests { get; set; }
        public ICollection<AcceptingSchoolTransfers> AcceptingSchoolTransfers { get; set; }
        public ICollection<ClassHistory> ClassHistory { get; set; }
        public ICollection<StudentsProfile> StudentsProfiles { get; set; }
        public ICollection<Team_Department> Departments { get; set; }
        public ICollection<Subject> Subjects { get; set; }
        public ICollection<Class> Classes { get; set; }
        public ICollection<Discipline> Disciplines { get; set; }
        public ICollection<Reward> Rewards { get; set; }
        public ICollection<TeacherProfile> TeacherProfiles { get; set; }
        public ICollection<LearningOutcomes> LearningOutcomes { get; set; }
        public ICollection<Faculty_StudyBlock> FacultyStudyBlocks { get; set; }
        public ICollection<Score> Scores { get; set; }
        public ICollection<Grades> Grades { get; set; }
        public ICollection<TrainingLevels> TrainingLevels { get; set; }
        public ICollection<Student_Submissions> StudentSubmissions { get; set; }
        public ICollection<Teaching_Assessment> TeachingAssessments { get; set; }
        public ICollection<LabSchedules> LabSchedules { get; set; }
        public ICollection<WorkHistories> WorkHistories { get; set; }
        public ICollection<Qualification> Qualifications { get; set; }
        public ICollection<Syllabus_topics> SyllabusTopics { get; set; }
        public ICollection<Class_Detail> ClassDetails { get; set; }
        public ICollection<SchoolProfile> SchoolProfiles { get; set; } // Assuming SchoolProfile can be linked to a SchoolYear

        [ForeignKey("School")]
        public int School_ID { get; set; }
        public SchoolProfile School { get; set; }
    }
}
