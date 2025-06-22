using ISC_BE02.Models;
using ISC_BE02.Interfaces;
using ISC_BE02.Services;
using Microsoft.AspNetCore.Mvc;

namespace ISC_BE02.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeamDepartmentController : ControllerBase
    {
        private readonly ITeamDepartmentService _service;
        public TeamDepartmentController(ITeamDepartmentService service)
        {
            _service = service;
        }

        // Tạo mới tổ bộ môn
        [HttpPost]
        public IActionResult CreateDepartment([FromBody] CreateDepartmentRequest request)
        {
            if (string.IsNullOrEmpty(request.DepartmentName) || request.SubjectIds == null || request.SubjectIds.Count == 0)
                return BadRequest("DepartmentName, HeadTeacherId, and SubjectIds are required.");
            var result = _service.CreateDepartment(
                request.DepartmentName,
                request.HeadTeacherId,
                request.SubjectIds,
                request.SchoolYearId,
                request.SchoolId
            );
            return Ok(result);
        }

        // Lấy danh sách tổ bộ môn
        [HttpGet]
        public IActionResult GetAllDepartments()
        {
            var result = _service.GetAllDepartments();
            return Ok(result);
        }

        // Lấy chi tiết tổ bộ môn
        [HttpGet("{id}")]
        public IActionResult GetDepartmentById(int id)
        {
            var result = _service.GetDepartmentById(id);
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

        // Lấy danh sách môn học
        [HttpGet("subjects")]
        public IActionResult GetAllSubjects()
        {
            var result = _service.GetAllSubjects();
            return Ok(result);
        }
    }

    public class CreateDepartmentRequest
    {
        public string? DepartmentName { get; set; }
        public int HeadTeacherId { get; set; }
        public List<int>? SubjectIds { get; set; }
        public int SchoolYearId { get; set; }
        public int SchoolId { get; set; }
    }
}
