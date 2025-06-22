using System.ComponentModel.DataAnnotations.Schema;

namespace ISC_BE02.Models
{
    public class LabScheduleClasses
    {
        [ForeignKey("LabSchedule")]
        public int LabSchedules_ID { get; set; }
        public LabSchedules LabSchedule { get; set; }

        [ForeignKey("Class")]
        public int Class_ID { get; set; }
        public Class Class { get; set; }
    }
}
