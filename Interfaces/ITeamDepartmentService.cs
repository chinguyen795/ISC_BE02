using ISC_BE02.Models;
using System.Collections.Generic;

namespace ISC_BE02.Interfaces
{
    public interface ITeamDepartmentService
    {
        Team_Department CreateDepartment(string departmentName, int headTeacherId, List<int> subjectIds, int schoolYearId, int schoolId);
        IEnumerable<Team_Department> GetAllDepartments();
        Team_Department? GetDepartmentById(int id);
        IEnumerable<TeacherProfile> GetAllTeachers();
        IEnumerable<Subject> GetAllSubjects();
    }
}
