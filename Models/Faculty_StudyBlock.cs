using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ISC_BE02.Models
{
    public enum FacultyNameType
    {
        FacultyOfIT,
        FacultyOfBusiness,
        // Add other faculties
    }
    public class Faculty_StudyBlock
    {
        [Key]
        public int Faculty_ID { get; set; }

        public FacultyNameType FacultyName { get; set; } // Using an enum

        public string FacultyCode { get; set; }

        [ForeignKey("User")]
        public int User_ID { get; set; }
        public User User { get; set; }

        [ForeignKey("School")]
        public int School_ID { get; set; }
        public SchoolProfile School { get; set; }

        [ForeignKey("SchoolYear")]
        public int SchoolYear_ID { get; set; }
        public SchoolYear SchoolYear { get; set; }

        public ICollection<Assignment> Assignments { get; set; }
    }
}
