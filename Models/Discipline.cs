using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ISC_BE02.Models
{
    public class Discipline
    {
        [Key]
        public int Discipline_ID { get; set; }

        public DateTime DisciplineDate { get; set; }

        public string Content { get; set; }

        public string DisciplineRewardURL { get; set; } // Combined from DisciplineRewardURL, could be separate

        public DateTime Decision_day { get; set; }

        public string FileURL { get; set; }

        [ForeignKey("User")]
        public int User_ID { get; set; }
        public User User { get; set; }

        [ForeignKey("Class")]
        public int Class_ID { get; set; }
        public Class Class { get; set; }
    }
}
