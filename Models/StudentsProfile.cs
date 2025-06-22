using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace ISC_BE02.Models
{
    public enum StudentForm
    {
        Regular,
        Transfer,
        Exchange
    }

    public enum StudentStatus
    {
        Active,
        Inactive,
        Graduated,
        DroppedOut
    }
    public class StudentsProfile
    {
        [Key]
        public int StudentsProfile_ID { get; set; }

        public string StudentName { get; set; }

        public string StudentCode { get; set; }

        public DateTime DateOfBirth { get; set; }

        public SexType Sex { get; set; } // Using an enum

        public string Nation { get; set; }

        public DateTime PlaceOfBirth { get; set; } // This is likely a string or refers to a location ID, not DateTime

        public string Religion { get; set; }

        public DateTime Admission_date { get; set; }

        public StudentForm Form { get; set; } // Using an enum

        public StudentStatus Status { get; set; } // Using an enum

        public int NumberRewards { get; set; }

        public int NumberDisciplinaryActions { get; set; }

        public string FileURL { get; set; }

        [ForeignKey("Class")]
        public int Class_ID { get; set; }
        public Class Class { get; set; }

        [ForeignKey("Department")]
        public int Department_ID { get; set; }
        public Team_Department Department { get; set; }

        [ForeignKey("User")]
        public int User_ID { get; set; }
        public User User { get; set; }

        [ForeignKey("SchoolYear")]
        public int SchoolYear_ID { get; set; }
        public SchoolYear SchoolYear { get; set; }
    }
}
