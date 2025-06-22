using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ISC_BE02.Models
{
    public enum SchoolType
    {
        University,
        College,
        HighSchool,
        MiddleSchool,
        PrimarySchool
    }
    public class SchoolProfile
    {
        [Key]
        public int School_ID { get; set; }

        public string SchoolName { get; set; }

        public string SchoolCode { get; set; }

        public string ProvinceCity { get; set; } // Renamed from Province/City

        public string CommuneWard { get; set; } // Renamed from Commune/Ward

        public string District { get; set; }

        public string Head_office { get; set; }

        public SchoolType SchoolType { get; set; } // Using an enum

        public string PhoneNumber { get; set; }

        public string PhoneFax { get; set; }

        public string Email { get; set; }

        public string DateEstablishment { get; set; } // This is likely a string or DateTime

        public string Training_model { get; set; }

        public string Webside { get; set; } // Typo, assuming Website

        public string PrincipalName { get; set; }

        public string PhonePrincipal { get; set; }

        public string FileURL { get; set; }

        [ForeignKey("SchoolYear")]
        public int SchoolYear_ID { get; set; }
        public SchoolYear SchoolYear { get; set; }

        public ICollection<SchoolYear> SchoolYears { get; set; } // Schools can have multiple school years
        public ICollection<Campus> Campuses { get; set; }
        public ICollection<Team_Department> Departments { get; set; }
        public ICollection<Faculty_StudyBlock> FacultyStudyBlocks { get; set; }
        public ICollection<CourseLessons> CourseLessons { get; set; }
    }
}
