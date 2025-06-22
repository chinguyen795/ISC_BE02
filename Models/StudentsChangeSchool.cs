using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ISC_BE02.Models
{
    public class StudentsChangeSchool
    {
        [Key]
        public int StudentsChangeSchool_ID { get; set; }

        public string Reason { get; set; }

        public int NameSchoolTransferred { get; set; } // This might refer to a School ID

        public int AddressSchoolTransferred { get; set; } // This might refer to an Address ID

        public string FileURL { get; set; }

        [ForeignKey("User")]
        public int User_ID { get; set; }
        public User User { get; set; }

        [ForeignKey("SchoolYear")]
        public int SchoolYear_ID { get; set; }
        public SchoolYear SchoolYear { get; set; }
    }
}
