using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ISC_BE02.Models
{
    public class ClassHistorySession
    {
        [Key]
        public int SessisonHistory_ID { get; set; }

        public string SessisonTotal { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        [ForeignKey("ClassHistory")]
        public int History_ID { get; set; }
        public ClassHistory ClassHistory { get; set; }
    }
}
