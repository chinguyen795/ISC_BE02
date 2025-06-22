using ISC_BE02.Models;
using System.Collections.Generic;

namespace ISC_BE02.Interfaces
{
    public interface ISchoolYearService
    {
        // Tạo mới niên khóa với các học kỳ
        SchoolYear CreateSchoolYear(string schoolYearName, DateTime startTime, DateTime endTime, int userId, int schoolId, List<SemesterDto> semesters);

        // Lấy danh sách niên khóa
        IEnumerable<SchoolYear> GetAllSchoolYears();

        // Lấy chi tiết niên khóa theo ID
        SchoolYear GetSchoolYearById(int id);
    }

    // DTO cho học kỳ để nhận dữ liệu từ API
    public class SemesterDto
    {
        public string? SemesterName { get; set; }
        public DateTime StartTimeSemester { get; set; }
        public DateTime EndTimeSemester { get; set; }
    }
}
