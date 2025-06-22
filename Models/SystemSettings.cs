using System.ComponentModel.DataAnnotations;

namespace ISC_BE02.Models
{
    public class SystemSettings
    {
        [Key]
        public string Setting_key { get; set; } // Primary key is a string

        public string Setting_value { get; set; }

        public string Description { get; set; }
    }
}
