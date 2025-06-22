using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace ISC_BE02.Models
{
    public class Reserved
    {
        [Key]
        public int Reason_ID { get; set; }

        public string Reason { get; set; }

        public DateTime DateReserved { get; set; }

        public int ReservedPeriod { get; set; }

        public string FileURL { get; set; }

        [ForeignKey("User")]
        public int User_ID { get; set; }
        public User User { get; set; }

        [ForeignKey("ClassPresent")]
        public int Class_IDPresent { get; set; }
        public Class ClassPresent { get; set; }

        [ForeignKey("ClassMoveTo")]
        public int Class_IDMoveTo { get; set; }
        public Class ClassMoveTo { get; set; }
    }
}
