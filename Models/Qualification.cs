using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ISC_BE02.Models
{
    public class Qualification
    {
        [Key]
        public int Qualifications_ID { get; set; }

        public string Institution { get; set; }

        public string Major { get; set; }

        public string Study_form { get; set; }

        public DateTime StarTime { get; set; }

        public DateTime Endtime { get; set; }

        public string Degree_name { get; set; }

        public string Attachment_url { get; set; }

        [ForeignKey("User")]
        public int User_ID { get; set; }
        public User User { get; set; }

        [ForeignKey("SchoolYear")]
        public int SchoolYear_ID { get; set; }
        public SchoolYear SchoolYear { get; set; }
    }
}
