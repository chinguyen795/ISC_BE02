using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ISC_BE02.Models
{
    public enum LiveSessionStatus
    {
        Scheduled,
        InProgress,
        Completed,
        Cancelled
    }
    public class LiveSessions
    {
        [Key]
        public int LiveSessions_ID { get; set; }

        public DateTime Scheduled_start_time { get; set; }

        public DateTime Actual_start_time { get; set; }

        public DateTime Actual_end_time { get; set; }

        public LiveSessionStatus Status { get; set; } // Using an enum

        public string Recording_url { get; set; }

        [ForeignKey("TeachingAssessment")]
        public int Teaching_ID { get; set; }
        public Teaching_Assessment TeachingAssessment { get; set; }

        public ICollection<LiveChatMessages> LiveChatMessages { get; set; }
    }
}
