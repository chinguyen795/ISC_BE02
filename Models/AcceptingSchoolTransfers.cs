using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ISC_BE02.Models
{
    public class AcceptingSchoolTransfers
    {
        [Key]
        public int AcceptingSchoolTransfers_ID { get; set; }

        public DateTime Move_in_Date { get; set; }

        public int SemesterMoveIn { get; set; }

        public string Province { get; set; }

        public string District { get; set; }

        public string Convert_from { get; set; }

        public string Reason { get; set; }

        public string FileURL { get; set; }

        [ForeignKey("User")]
        public int User_ID { get; set; }
        public User User { get; set; }

        [ForeignKey("SchoolYear")]
        public int SchoolYear_ID { get; set; }
        public SchoolYear SchoolYear { get; set; }
    }
}
