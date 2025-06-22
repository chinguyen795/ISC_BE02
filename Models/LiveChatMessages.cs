using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ISC_BE02.Models
{
    public class LiveChatMessages
    {
        [Key]
        public int LiveChatMessages_ID { get; set; }

        public string Message_content { get; set; }

        public DateTime SentAt { get; set; }

        public string Recording_url { get; set; } // This seems misplaced in LiveChatMessages, perhaps should be in LiveSessions. Keeping as per diagram.

        [ForeignKey("LiveSession")]
        public int LiveSessions_ID { get; set; }
        public LiveSessions LiveSession { get; set; }

        [ForeignKey("User")]
        public int User_ID { get; set; }
        public User User { get; set; }
    }
}
