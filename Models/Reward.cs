using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ISC_BE02.Models
{
    public class Reward
    {
        [Key]
        public int Reward_ID { get; set; }

        public DateTime RewardDate { get; set; }

        public string Content { get; set; }

        public string Type { get; set; } // Renamed from 'KeyField' to 'Type' based on diagram

        public string DecisionRewardURL { get; set; }

        public DateTime Decision_day { get; set; }

        public string FileURL { get; set; }

        [ForeignKey("User")]
        public int User_ID { get; set; }
        public User User { get; set; }

        [ForeignKey("Class")]
        public int Class_ID { get; set; }
        public Class Class { get; set; }
    }
}
