using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ISC_BE02.Models
{
    public enum TeacherPosition
    {
        Professor,
        AssociateProfessor,
        Lecturer,
        AssistantLecturer
    }

    public enum TeacherStatus
    {
        Active,
        OnLeave,
        Retired
    }

    public enum TeacherForm
    {
        FullTime,
        PartTime,
        Contract
    }
    public class TeacherProfile
    {
        [Key]
        public int Teacher_ID { get; set; }

        public string Type { get; set; } // Renamed from 'Type' to 'TeacherType' to avoid conflict, but 'Type' in diagram is ambiguous. Assuming string.

        public string TeacherName { get; set; }

        public string TeacherCode { get; set; }

        public TeacherPosition Position { get; set; } // Using an enum

        public bool Member { get; set; } // Bool for Member status

        public bool Party_member { get; set; } // Bool for Party member status

        public DateTime DateOfBirth { get; set; }

        public string Nation { get; set; }

        public TeacherStatus Status { get; set; } // Using an enum

        public DateTime PlaceOfBirth { get; set; } // This is likely a string or refers to a location ID, not DateTime

        public string Religion { get; set; }

        public DateTime Admission_date { get; set; }

        public TeacherForm Form { get; set; } // Using an enum

        // Status is repeated, assuming one is sufficient or they refer to different statuses. Using TeacherStatus.
        // public TeacherStatus Status { get; set; }

        public string Addres { get; set; } // Typo in diagram, assuming "Address"

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public int NumberRewards { get; set; }

        public int NumberDisciplinaryActions { get; set; }

        public string FileURL { get; set; }

        [ForeignKey("Subject")]
        public int Subject_ID { get; set; }
        public Subject Subject { get; set; }

        [ForeignKey("Department")]
        public int Department_ID { get; set; }
        public Team_Department Department { get; set; }

        [ForeignKey("User")]
        public int User_ID { get; set; }
        public User User { get; set; }

        [ForeignKey("SchoolYear")]
        public int SchoolYear_ID { get; set; }
        public SchoolYear SchoolYear { get; set; }

        [ForeignKey("Class")]
        public int Class_ID { get; set; }
        public Class Class { get; set; }
    }
}
