using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ISC_BE02.Models
{
    public class ClassSessions
    {
        [Key]
        public int Session_ID { get; set; }

        public string Topic { get; set; }

        public string Description { get; set; }

        public int Duration_hours { get; set; }

        public int Duration_minutes { get; set; }

        public DateTime StartDatetime { get; set; }

        public DateTime EndDatetime { get; set; }

        public bool IsPrivate { get; set; }

        public bool AutoStart { get; set; }

        public bool EnableRecording { get; set; }

        public bool AllowSharing { get; set; }

        public string ShareLink { get; set; }

        [ForeignKey("User")]
        public int User_ID { get; set; }
        public User User { get; set; }

        [ForeignKey("Class")]
        public int Class_ID { get; set; }
        public Class Class { get; set; }
    }
}
