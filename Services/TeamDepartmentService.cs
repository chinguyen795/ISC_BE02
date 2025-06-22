using ISC_BE02.Models;
using ISC_BE02.Interfaces;
using ISC_BE02.Data;
using Microsoft.EntityFrameworkCore;

namespace ISC_BE02.Services
{
    public class TeamDepartmentService : ITeamDepartmentService
    {
        private readonly ApplicationDbContext _context;
        public TeamDepartmentService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Team_Department CreateDepartment(string departmentName, int headTeacherId, List<int> subjectIds, int schoolYearId, int schoolId)
        {
            var department = new Team_Department
            {
                DepartmentName = Enum.TryParse<DepartmentNameType>(departmentName, out var depName) ? depName : DepartmentNameType.Science,
                User_ID = headTeacherId,
                SchoolYear_ID = schoolYearId,
                School_ID = schoolId,
                Subjects = new List<Subject>()
            };
            var subjects = _context.Subjects.Where(s => subjectIds.Contains(s.Subjects_ID)).ToList();
            foreach (var subject in subjects)
            {
                department.Subjects.Add(subject);
            }
            _context.Team_Department.Add(department);
            _context.SaveChanges();
            return department;
        }

        public IEnumerable<Team_Department> GetAllDepartments()
        {
            return _context.Team_Department.Include(d => d.Subjects).Include(d => d.User).ToList();
        }

        public Team_Department? GetDepartmentById(int id)
        {
            return _context.Team_Department.Include(d => d.Subjects).Include(d => d.User).FirstOrDefault(d => d.Department_ID == id);
        }

        public IEnumerable<TeacherProfile> GetAllTeachers()
        {
            return _context.TeacherProfile.ToList();
        }

        public IEnumerable<Subject> GetAllSubjects()
        {
            return _context.Subjects.ToList();
        }
    }
}
