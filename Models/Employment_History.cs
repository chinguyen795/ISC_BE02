using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ISC_BE02.Models
{
    public enum EmploymentStatus
    {
        Current,
        Past,
        Terminated
    }
    public class Employment_History
    {
        [Key]
        public int History_ID { get; set; }

        public EmploymentStatus Status { get; set; } // Using an enum

        public DateTime Effective_date { get; set; }

        public string Note { get; set; }

        public string Certificate { get; set; }

        public string Form { get; set; }

        public string DecidedRetireURL { get; set; }

        [ForeignKey("CreatedByUser")]
        public int CreatedByID { get; set; }
        public User CreatedByUser { get; set; }

        [ForeignKey("User")]
        public int User_ID { get; set; }
        public User User { get; set; }
    }
}
