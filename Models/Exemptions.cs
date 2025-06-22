using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ISC_BE02.Models
{
    public enum ExemptionObject
    {
        Student,
        Teacher,
        Staff
    }

    public enum FormExemption
    {
        Temporary,
        Permanent
    }
    public class Exemptions
    {
        [Key]
        public int Exemptions_ID { get; set; }

        public ExemptionObject ExemptionObjects { get; set; } // Using an enum

        public FormExemption FormExemption { get; set; } // Using an enum

        [ForeignKey("User")]
        public int User_ID { get; set; }
        public User User { get; set; }

        [ForeignKey("Class")]
        public int Class_ID { get; set; }
        public Class Class { get; set; }
    }
}
