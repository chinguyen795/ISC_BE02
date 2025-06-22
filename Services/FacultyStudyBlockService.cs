using ISC_BE02.Models;
using ISC_BE02.Interfaces;
using ISC_BE02.Data;
using Microsoft.EntityFrameworkCore;

namespace ISC_BE02.Services
{
    public class FacultyStudyBlockService : IFacultyStudyBlockService
    {
        private readonly ApplicationDbContext _context;
        public FacultyStudyBlockService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Faculty_StudyBlock CreateFaculty(string facultyName, int headTeacherId, int schoolYearId, int schoolId)
        {
            // Sinh mã khoa tự động: VD: K + số thứ tự
            int nextId = (_context.Faculty_StudyBlock.Any() ? _context.Faculty_StudyBlock.Max(f => f.Faculty_ID) : 0) + 1;
            string code = $"K{nextId}";
            var faculty = new Faculty_StudyBlock
            {
                FacultyName = Enum.TryParse<FacultyNameType>(facultyName, out var fName) ? fName : FacultyNameType.FacultyOfIT,
                FacultyCode = code,
                User_ID = headTeacherId,
                SchoolYear_ID = schoolYearId,
                School_ID = schoolId
            };
            _context.Faculty_StudyBlock.Add(faculty);
            _context.SaveChanges();
            return faculty;
        }

        public IEnumerable<Faculty_StudyBlock> GetAllFaculties()
        {
            return _context.Faculty_StudyBlock.Include(f => f.User).ToList();
        }

        public Faculty_StudyBlock? GetFacultyById(int id)
        {
            return _context.Faculty_StudyBlock.Include(f => f.User).FirstOrDefault(f => f.Faculty_ID == id);
        }

        public IEnumerable<TeacherProfile> GetAllTeachers()
        {
            return _context.TeacherProfile.ToList();
        }
    }
}
