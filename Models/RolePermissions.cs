using System.ComponentModel.DataAnnotations.Schema;

namespace ISC_BE02.Models
{
    public class RolePermissions
    {
        [ForeignKey("Role")]
        public int Role_ID { get; set; }
        public Role Role { get; set; }

        [ForeignKey("Permissions")]
        public int Permissions_ID { get; set; }
        public Permissions Permissions { get; set; }
    }
}
