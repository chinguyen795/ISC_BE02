using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ISC_BE02.Models
{
    public enum SexType
    {
        Male,
        Female,
        Other
    }
    public enum PaymentStatus
    {
        Pending,
        Paid,
        Failed
    }
    public class Registrations
    {
        [Key]
        public int Registrations_ID { get; set; }

        public DateTime Registration_date { get; set; }

        public string CourserName { get; set; }

        public string Campus { get; set; }

        public string StudentName { get; set; }

        public DateTime BirdDay { get; set; }

        public SexType Sex { get; set; } // Using an enum

        public string Nationality { get; set; }

        public string Education_level { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public PaymentStatus Payment_status { get; set; } // Using an enum

        public string Registrations_Image_Url { get; set; }

        [ForeignKey("StudentUser")]
        public int Student_user_id { get; set; }
        public User StudentUser { get; set; }

        [ForeignKey("CourseOfferings")]
        public int CourseOfferings_ID { get; set; }
        public CourseOfferings CourseOfferings { get; set; }
    }
}
