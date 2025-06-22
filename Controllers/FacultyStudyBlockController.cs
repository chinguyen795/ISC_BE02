using ISC_BE02.Models;
using ISC_BE02.Interfaces;
using ISC_BE02.Services;
using Microsoft.AspNetCore.Mvc;

namespace ISC_BE02.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FacultyStudyBlockController : ControllerBase
    {
        private readonly IFacultyStudyBlockService _service;
        public FacultyStudyBlockController(IFacultyStudyBlockService service)
        {
            _service = service;
        }

        // Tạo mới khoa/khối
        [HttpPost]
        public IActionResult CreateFaculty([FromBody] CreateFacultyRequest request)
        {
            if (string.IsNullOrEmpty(request.FacultyName))
                return BadRequest("FacultyName is required.");
            var result = _service.CreateFaculty(
                request.FacultyName,
                request.HeadTeacherId,
                request.SchoolYearId,
                request.SchoolId
            );
            return Ok(result);
        }

        // Lấy danh sách khoa/khối
        [HttpGet]
        public IActionResult GetAllFaculties()
        {
            var result = _service.GetAllFaculties();
            return Ok(result);
        }

        // Lấy chi tiết khoa/khối
        [HttpGet("{id}")]
        public IActionResult GetFacultyById(int id)
        {
            var result = _service.GetFacultyById(id);
            if (result == null) return NotFound();
            return Ok(result);
        }

        // Lấy danh sách giáo viên
        [HttpGet("teachers")]
        public IActionResult GetAllTeachers()
        {
            var result = _service.GetAllTeachers();
            return Ok(result);
        }
    }

    public class CreateFacultyRequest
    {
        public string? FacultyName { get; set; }
        public int HeadTeacherId { get; set; }
        public int SchoolYearId { get; set; }
        public int SchoolId { get; set; }
    }
}
