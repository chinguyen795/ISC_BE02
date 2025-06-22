using static System.Formats.Asn1.AsnWriter;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ISC_BE02.Models
{
    public enum ClassNameType
    {
       L6, L7, L8, L9, L10, L11, L12
    }

    public enum ClassClassification
    {
        Theory,
        Lab,
        Seminar
    }

    public enum ClassStatus
    {
        Active,
        Closed,
        Archived
    }
    public class Class
    {
        [Key]
        public int Class_ID { get; set; }

        public ClassNameType ClassName { get; set; } // Using an enum

        public string ClassCode { get; set; }

        public string ClassPassword { get; set; }

        public int StudentNumber { get; set; }

        public ClassClassification ClassClassification { get; set; } // Using an enum

        public string FileClassURL { get; set; }

        public string Description { get; set; }

        public int Number_of_sessions { get; set; }

        public ClassStatus Status { get; set; } // Using an enum

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public string ClassURL { get; set; }

        public string Join_code { get; set; }

        public string Join_password { get; set; }

        [ForeignKey("User")]
        public int User_ID { get; set; }
        public User User { get; set; } // User who manages/created the class

        [ForeignKey("Department")]
        public int Department_ID { get; set; }
        public Team_Department Department { get; set; }

        [ForeignKey("SchoolYear")]
        public int SchoolYear_ID { get; set; }
        public SchoolYear SchoolYear { get; set; }

        [ForeignKey("ClassroomSettings")]
        public int ClassroomSettings_ID { get; set; }
        public ClassroomSettings ClassroomSettings { get; set; }

        [ForeignKey("ClassType")]
        public int ClassType_ID { get; set; }
        public ClassType ClassType { get; set; }

        public ICollection<StudentsChangeClasses> StudentsChangeClassesPresent { get; set; }
        public ICollection<StudentsChangeClasses> StudentsChangeClassesMoveTo { get; set; }
        public ICollection<Reserved> ReservedPresent { get; set; }
        public ICollection<Reserved> ReservedMoveTo { get; set; }
        public ICollection<ClassHistory> ClassHistory { get; set; }
        public ICollection<Subjects_Class> Subjects_Classes { get; set; }
        public ICollection<Class_Detail> ClassDetails { get; set; }
        public ICollection<Exemptions> Exemptions { get; set; }
        public ICollection<Discipline> Disciplines { get; set; }
        public ICollection<Reward> Rewards { get; set; }
        public ICollection<ClassSessions> ClassSessions { get; set; }
        public ICollection<TeacherProfile> TeacherProfiles { get; set; }
        public ICollection<Score> Scores { get; set; }
        public ICollection<Teaching_Assessment> TeachingAssessments { get; set; }
        public ICollection<Assignment_Group> Assignment_Groups { get; set; }
        public ICollection<LabScheduleClasses> LabScheduleClasses { get; set; }
        public ICollection<StudentsProfile> StudentsProfiles { get; set; }
        public ICollection<WorkHistories> WorkHistories { get; set; } // Assuming WorkHistories also linked to Class
    }
}
