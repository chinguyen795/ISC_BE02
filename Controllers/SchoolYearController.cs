using ISC_BE02.Models;
using ISC_BE02.Interfaces;
using ISC_BE02.Services;
using Microsoft.AspNetCore.Mvc;

namespace ISC_BE02.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SchoolYearController : ControllerBase
    {
        private readonly ISchoolYearService _schoolYearService;
        public SchoolYearController(ISchoolYearService schoolYearService)
        {
            _schoolYearService = schoolYearService;
        }

        // Tạo mới niên khóa với các học kỳ
        [HttpPost]
        public IActionResult CreateSchoolYear([FromBody] CreateSchoolYearRequest request)
        {
            if (string.IsNullOrEmpty(request.SchoolYearName) || request.Semesters == null)
                return BadRequest("SchoolYearName and Semesters are required.");
            var schoolYear = _schoolYearService.CreateSchoolYear(
                request.SchoolYearName,
                request.StartTime,
                request.EndTime,
                request.User_ID,
                request.School_ID,
                request.Semesters
            );
            return Ok(schoolYear);
        }

        // Lấy danh sách niên khóa
        [HttpGet]
        public IActionResult GetAllSchoolYears()
        {
            var result = _schoolYearService.GetAllSchoolYears();
            return Ok(result);
        }

        // Lấy chi tiết niên khóa theo ID
        [HttpGet("{id}")]
        public IActionResult GetSchoolYearById(int id)
        {
            var result = _schoolYearService.GetSchoolYearById(id);
            if (result == null) return NotFound();
            return Ok(result);
        }
    }

    // Request model cho tạo mới niên khóa
    public class CreateSchoolYearRequest
    {
        public string? SchoolYearName { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int User_ID { get; set; }
        public int School_ID { get; set; }
        public List<SemesterDto>? Semesters { get; set; }
    }
}
