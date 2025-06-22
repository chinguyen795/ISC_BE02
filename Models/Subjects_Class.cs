using System.ComponentModel.DataAnnotations.Schema;

namespace ISC_BE02.Models
{
    public class Subjects_Class
    {
        [ForeignKey("Subject")]
        public int Subjects_ID { get; set; }
        public Subject Subject { get; set; }

        [ForeignKey("Class")]
        public int Class_ID { get; set; }
        public Class Class { get; set; }
    }
}
