using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ISC_BE02.Models
{
    public class TrainingLevels
    {
        [Key]
        public int Training_ID { get; set; }

        public string TrainingName { get; set; }

        public string TrainingForm { get; set; }

        public bool Is_credit_based { get; set; }

        public DateTime Is_credit_year_based { get; set; } // This field name and type seem unusual for "is credit year based". Assuming it's a date or perhaps should be a bool. Keeping as DateTime for now as per diagram.

        public int Duration_years { get; set; }

        public int Required_credits { get; set; }

        public int Elective_credits { get; set; }

        public string Note { get; set; }

        public bool Is_active { get; set; }

        [ForeignKey("SchoolYear")]
        public int SchoolYear_ID { get; set; }
        public SchoolYear SchoolYear { get; set; }

        public ICollection<Grades> Grades { get; set; }
    }

    public class Student_Grades
    {
        [Key]
        public int Student_Grades_ID { get; set; }

        public int Submission_id { get; set; }

        public double Score { get; set; }

        public string Comments { get; set; }

        public DateTime Graded_time { get; set; }

        [ForeignKey("User")]
        public int User_ID { get; set; }
        public User User { get; set; }
    }
}
