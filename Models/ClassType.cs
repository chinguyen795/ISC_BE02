using System.ComponentModel.DataAnnotations;

namespace ISC_BE02.Models
{
    public class ClassType
    {
        [Key]
        public int ClassType_ID { get; set; }

        public string ClassTypeName { get; set; }

        public string Note { get; set; }

        public bool Status { get; set; }

        public ICollection<Class> Classes { get; set; }
    }
}
