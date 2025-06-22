using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace ISC_BE02.Models
{
    public class StudentsChangeClasses
    {
        [Key]
        public int StudentsChangeClasses_ID { get; set; }

        public string Reason { get; set; }
        public string FileURL { get; set; }

        [ForeignKey("ClassPresent")]
        public int Class_IDPresent { get; set; }
        public Class ClassPresent { get; set; }

        [ForeignKey("ClassMoveTo")]
        public int Class_IDMoveTo { get; set; }
        public Class ClassMoveTo { get; set; }

        [ForeignKey("User")]
        public int User_ID { get; set; }
        public User User { get; set; }
    }
}
