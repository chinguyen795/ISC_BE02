using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ISC_BE02.Models
{
    public enum DiscussionTitleType
    {
        General,
        Technical,
        CourseRelated
    }

    public class DiscussionThreads
    {
        [Key]
        public int Discussion_ID { get; set; }

        public DiscussionTitleType Title { get; set; } // Using an enum

        public DateTime Visibility { get; set; } // This is likely a status (public/private) or a date when it becomes visible. Assuming DateTime for now.

        public bool Is_resolved { get; set; }

        public int View_count { get; set; }

        public DateTime CreateAt { get; set; }

        [ForeignKey("User")]
        public int User_ID { get; set; }
        public User User { get; set; }

        [ForeignKey("TeachingAssessment")]
        public int Teaching_ID { get; set; }
        public Teaching_Assessment TeachingAssessment { get; set; }

        public ICollection<ThreadPosts> ThreadPosts { get; set; }
    }
}
