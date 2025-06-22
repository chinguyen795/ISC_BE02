using System.ComponentModel.DataAnnotations.Schema;

namespace ISC_BE02.Models
{
    public class LabGraders
    {
        [ForeignKey("LabSchedule")]
        public int LabSchedules_ID { get; set; }
        public LabSchedules LabSchedule { get; set; }

        [ForeignKey("User")]
        public int User_ID { get; set; }
        public User User { get; set; }
    }
}
