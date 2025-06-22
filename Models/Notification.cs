using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ISC_BE02.Models
{
    public enum ReceivingObject
    {
        AllUsers,
        Students,
        Teachers,
        Admins
    }
    public class Notification
    {
        [Key]
        public int Notification_ID { get; set; }

        public ReceivingObject ReceivingObject { get; set; } // Using an enum

        public string Title { get; set; }

        public DateTime CreateAt { get; set; }

        public DateTime UpdateAt { get; set; }

        [ForeignKey("User")]
        public int User_ID { get; set; }
        public User User { get; set; }
    }
}
