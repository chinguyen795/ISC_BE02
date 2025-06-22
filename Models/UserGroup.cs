using System.ComponentModel.DataAnnotations;

namespace ISC_BE02.Models
{
    public enum UserGroupStatus
    {
        Active,
        Inactive
    }
    public class UserGroup
    {
        [Key]
        public int Group_ID { get; set; }

        public string GroupName { get; set; }

        public string Description { get; set; }

        public UserGroupStatus Status { get; set; } // Using an enum

        public ICollection<User> Users { get; set; }
        public ICollection<Decentralization> Decentralizations { get; set; }
    }
}
