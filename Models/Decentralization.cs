using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ISC_BE02.Models
{
    public class Decentralization
    {
        [Key]
        public int Decentralization_ID { get; set; }

        public string DecentralizationName { get; set; }

        public string Description { get; set; }

        public bool Is_True { get; set; }

        [ForeignKey("UserGroup")]
        public int Group_ID { get; set; }
        public UserGroup UserGroup { get; set; }
    }
}
