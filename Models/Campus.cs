using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ISC_BE02.Models
{
    public class Campus
    {
        [Key]
        public int Campuses_ID { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public int phone_number { get; set; } // This might be a string for phone numbers with special characters

        public string Email { get; set; }

        public string Manager_name { get; set; }

        [ForeignKey("School")]
        public int School_ID { get; set; }
        public SchoolProfile School { get; set; }
    }
}
