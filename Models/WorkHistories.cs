using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ISC_BE02.Models
{
    public enum WorkDepartment
    {
        HR,
        Finance,
        Academics
    }

    public enum WorkPosition
    {
        Manager,
        Staff,
        Officer
    }
    public class WorkHistories
    {
        [Key]
        public int Word_ID { get; set; } // Typo in diagram, assuming Work_ID

        public string Organization_name { get; set; }

        public WorkDepartment Department { get; set; } // Using an enum

        public WorkPosition Position { get; set; } // Using an enum

        public DateTime StarTime { get; set; }

        public DateTime Endtime { get; set; }

        public string Description { get; set; }

        public string CertificateName { get; set; }

        public string TrainingType { get; set; } // Renamed from 'KeyTrainingType' to 'TrainingType'

        [ForeignKey("User")]
        public int User_ID { get; set; }
        public User User { get; set; }

        [ForeignKey("SchoolYear")]
        public int SchoolYear_ID { get; set; }
        public SchoolYear SchoolYear { get; set; }

        [ForeignKey("Class")]
        public int Class_ID { get; set; }
        public Class Class { get; set; }
    }
}
