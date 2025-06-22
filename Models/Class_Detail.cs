using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace ISC_BE02.Models
{
    public enum ClassDetailStatus
    {
        Active,
        Inactive,
        Completed
    }
    public class Class_Detail
    {
        [Key]
        public int Detail_Class_ID { get; set; }

        public DateTime Admission_date { get; set; }

        public ClassDetailStatus Status { get; set; } // Using an enum

        public int NumberOfSubjects { get; set; }

        public string Description { get; set; }

        [ForeignKey("StudentUser")]
        public int Student_ID { get; set; }
        public User StudentUser { get; set; } // Assuming Student_ID refers to a User

        [ForeignKey("Class")]
        public int Class_ID { get; set; }
        public Class Class { get; set; }

        [ForeignKey("Department")]
        public int Department_ID { get; set; }
        public Team_Department Department { get; set; }

        [ForeignKey("User")]
        public int User_ID { get; set; }
        public User User { get; set; } // Assuming User_ID refers to a User managing this detail

        [ForeignKey("SchoolYear")]
        public int SchoolYear_ID { get; set; }
        public SchoolYear SchoolYear { get; set; }
    }
}
