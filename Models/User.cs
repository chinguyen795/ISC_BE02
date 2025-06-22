using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Security.Claims;

namespace ISC_BE02.Models
{
    public enum UserStatus
    {
        Active,
        Inactive,
        Suspended
    }
    public class User
    {
        [Key]
        public int User_ID { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string FullName { get; set; }

        public string EmailEmail { get; set; } // Consider renaming to Email

        public string AvatarURL { get; set; }

        public UserStatus Status { get; set; } // Using an enum

        public DateTime CreateAt { get; set; }

        public DateTime UpdateAt { get; set; }
        public ICollection<ClassHistory> ClassHistory { get; set; }

        [ForeignKey("ClassHistory")]
        public int? History_ID { get; set; }  
        public ClassHistory CurrentClassHistory { get; set; }

        [ForeignKey("UserGroup")]
        public int Group_ID { get; set; }
        public UserGroup UserGroup { get; set; }

        [ForeignKey("Role")]
        public int Role_ID { get; set; }
        public Role Role { get; set; }

        [ForeignKey("SchoolYear")]
        public int SchoolYear_ID { get; set; }
        public SchoolYear SchoolYear { get; set; }
    
        // Navigation properties for relationships where User is on the "many" side

        public ICollection<TotalCoursesTaken> TotalCoursesTaken { get; set; }
        public ICollection<SchoolYear> SchoolYearsCreated { get; set; } // Assuming User can create SchoolYears
        public ICollection<StudentsChangeSchool> StudentsChangeSchoolRequests { get; set; }
        public ICollection<StudentsChangeClasses> StudentsChangeClassesRequests { get; set; }
        public ICollection<Reserved> ReservedRequests { get; set; }
        public ICollection<AcceptingSchoolTransfers> AcceptingSchoolTransfers { get; set; }
        public ICollection<ClassHistory> ClassHistoryManaged { get; set; }
        public ICollection<Registrations> Registrations { get; set; }
        public ICollection<Notification> Notifications { get; set; }
        public ICollection<StudentsProfile> StudentsProfiles { get; set; }
        public ICollection<Subject> SubjectsCreated { get; set; }
        public ICollection<Class_Detail> ClassDetailsAsStudent { get; set; } // For Student_ID in Class_Detail
        public ICollection<Class_Detail> ClassDetailsManaged { get; set; } // For User_ID in Class_Detail
        public ICollection<Team_Department> DepartmentsManaged { get; set; }
        public ICollection<CourseOfferings> CourseOfferingsTaught { get; set; }
        public ICollection<Class> ClassesManaged { get; set; }
        public ICollection<Exemptions> Exemptions { get; set; }
        public ICollection<Discipline> Disciplines { get; set; }
        public ICollection<Reward> Rewards { get; set; }
        public ICollection<StudentMCQAnswers> StudentMCQAnswers { get; set; }
        public ICollection<ClassSessions> ClassSessions { get; set; }
        public ICollection<PastClasses> PastClasses { get; set; }
        public ICollection<UpcomingClass> UpcomingClasses { get; set; }
        public ICollection<TeacherProfile> TeacherProfiles { get; set; }
        public ICollection<LearningOutcomes> LearningOutcomes { get; set; }
        public ICollection<Faculty_StudyBlock> FacultyStudyBlocks { get; set; }
        public ICollection<Grades> Grades { get; set; }
        public ICollection<Student_Grades> StudentGrades { get; set; }
        public ICollection<Teaching_Assessment> TeachingAssessments { get; set; }
        public ICollection<Student_Submissions> StudentSubmissions { get; set; }
        public ICollection<LabSchedules> LabSchedules { get; set; }
        public ICollection<LabGraders> LabGraders { get; set; }
        public ICollection<Question> Questions { get; set; }
        public ICollection<WorkHistories> WorkHistories { get; set; }
        public ICollection<Employment_History> EmploymentHistories { get; set; }
        public ICollection<Employment_History> EmploymentHistoriesCreated { get; set; } // For CreatedByID in Employment_History
        public ICollection<Qualification> Qualifications { get; set; }
        public ICollection<LiveChatMessages> LiveChatMessages { get; set; }
        public ICollection<ThreadPosts> ThreadPosts { get; set; }
        public ICollection<DiscussionThreads> DiscussionThreads { get; set; }
    }
}
