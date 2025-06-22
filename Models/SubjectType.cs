using System.ComponentModel.DataAnnotations;

namespace ISC_BE02.Models
{
    public class SubjectType
    {
        [Key]
        public int SubjectType_ID { get; set; }

        public string SubjectTypeName { get; set; }

        public string Description { get; set; }

        public bool Status { get; set; }

        public string Note { get; set; }

        public ICollection<Subject> Subjects { get; set; }
    }
}
