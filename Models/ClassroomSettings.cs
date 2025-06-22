using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace ISC_BE02.Models
{
    public enum ClassroomSettingStatus
    {
        Active,
        Inactive,
        Maintenance
    }
    public class ClassroomSettings
    {
        [Key]
        public int ClassroomSettings_ID { get; set; }

        public ClassroomSettingStatus Status { get; set; } // Using an enum

        public string Description { get; set; }

        public ICollection<Class> Classes { get; set; }
    }
}
