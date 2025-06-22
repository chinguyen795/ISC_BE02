using ISC_BE02.Models;
using System.Collections.Generic;

namespace ISC_BE02.Interfaces
{
    public interface IFacultyStudyBlockService
    {
        Faculty_StudyBlock CreateFaculty(string facultyName, int headTeacherId, int schoolYearId, int schoolId);
        IEnumerable<Faculty_StudyBlock> GetAllFaculties();
        Faculty_StudyBlock? GetFacultyById(int id);
        IEnumerable<TeacherProfile> GetAllTeachers();
    }
}
