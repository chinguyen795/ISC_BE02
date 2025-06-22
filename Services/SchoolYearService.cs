using ISC_BE02.Models;
using ISC_BE02.Interfaces;
using ISC_BE02.Data;
using Microsoft.EntityFrameworkCore;

namespace ISC_BE02.Services
{
    public class SchoolYearService : ISchoolYearService
    {
        private readonly ApplicationDbContext _context;
        public SchoolYearService(ApplicationDbContext context)
        {
            _context = context;
        }

        public SchoolYear CreateSchoolYear(string schoolYearName, DateTime startTime, DateTime endTime, int userId, int schoolId, List<SemesterDto> semesters)
        {
            var schoolYear = new SchoolYear
            {
                SchoolYearName = schoolYearName,
                StartTime = startTime,
                EndTime = endTime,
                User_ID = userId,
                School_ID = schoolId,
                Semesters = new List<Semester>()
            };

            foreach (var sem in semesters)
            {
                var semester = new Semester
                {
                    SemesterName = sem.SemesterName,
                    StartTimeSemester = sem.StartTimeSemester,
                    EndTimeSemester = sem.EndTimeSemester
                };
                schoolYear.Semesters.Add(semester);
            }

            _context.SchoolYears.Add(schoolYear);
            _context.SaveChanges();
            return schoolYear;
        }

        public IEnumerable<SchoolYear> GetAllSchoolYears()
        {
            return _context.SchoolYears.Include(sy => sy.Semesters).ToList();
        }

        public SchoolYear GetSchoolYearById(int id)
        {
            return _context.SchoolYears.Include(sy => sy.Semesters).FirstOrDefault(sy => sy.SchoolYear_ID == id);
        }
    }
}
