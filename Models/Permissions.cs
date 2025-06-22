using System.ComponentModel.DataAnnotations;

namespace ISC_BE02.Models
{
    public class Permissions
    {
        [Key]
        public int Permissions_ID { get; set; }

        public string Feature_name { get; set; }

        public string Action_name { get; set; }

        public string Description { get; set; }

        public ICollection<RolePermissions> RolePermissions { get; set; }
    }
}
