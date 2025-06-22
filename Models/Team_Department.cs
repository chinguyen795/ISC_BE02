using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace ISC_BE02.Models
{
    public enum DepartmentNameType
    {
        Science,
        Arts,
        Mathematics,
        // ... other department names
    }
    public class Team_Department
    {
        [Key]
        public int Department_ID { get; set; }

        public DepartmentNameType DepartmentName { get; set; } // Using an enum

        [ForeignKey("SchoolYear")]
        public int SchoolYear_ID { get; set; }
        public SchoolYear SchoolYear { get; set; }

        [ForeignKey("User")]
        public int User_ID { get; set; }
        public User User { get; set; } // Assuming a user manages this department

        [ForeignKey("School")]
        public int School_ID { get; set; }
        public SchoolProfile School { get; set; }

        public ICollection<Class_Detail> ClassDetails { get; set; }
        public ICollection<StudentsProfile> StudentsProfiles { get; set; }
        public ICollection<Subject> Subjects { get; set; }
        public ICollection<Class> Classes { get; set; }
        public ICollection<TeacherProfile> TeacherProfiles { get; set; }
    }
}
