using System.ComponentModel.DataAnnotations.Schema;

namespace ISC_BE02.Models
{
    public class Assignment_Group
    {
        [ForeignKey("Assignment")]
        public int Assignments_ID { get; set; }
        public Assignment Assignment { get; set; }

        [ForeignKey("Class")]
        public int Class_ID { get; set; }
        public Class Class { get; set; }
    }
}
