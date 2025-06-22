using System.ComponentModel.DataAnnotations;

namespace ISC_BE02.Models
{
    public enum RoleNameType
    {
        Admin,
        Teacher,
        Student
    }
    public class Role
    {
        [Key]
        public int Role_ID { get; set; }

        public RoleNameType RoleName { get; set; } // Using an enum

        public string Description { get; set; }

        public bool Is_admin { get; set; }

        public ICollection<User> Users { get; set; }
        public ICollection<RolePermissions> RolePermissions { get; set; }

    }
}
