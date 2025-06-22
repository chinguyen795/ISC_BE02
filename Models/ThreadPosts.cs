using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ISC_BE02.Models
{
    public class ThreadPosts
    {
        [Key]
        public int ThreadPosts_ID { get; set; }

        public string Content { get; set; }

        public DateTime Created_at { get; set; }

        public string Attachment_url { get; set; }

        [ForeignKey("DiscussionThread")]
        public int Discussion_ID { get; set; }
        public DiscussionThreads DiscussionThread { get; set; }

        [ForeignKey("User")]
        public int User_ID { get; set; }
        public User User { get; set; }
    }
}
