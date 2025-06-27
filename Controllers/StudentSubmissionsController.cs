// Controllers/StudentSubmissionsController.cs
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ISC_BE02.Data;
using ISC_BE02.Models;

namespace ISC_BE02.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentSubmissionsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public StudentSubmissionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/StudentSubmissions
        // Retrieves all student submissions.
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Student_Submissions>>> GetStudentSubmissions()
        {
            // The DbSet name is 'Student_Submissions' as defined in ApplicationDbContext
            return await _context.Student_Submissions.ToListAsync();
        }

        // GET: api/StudentSubmissions/5
        // Retrieves a single student submission by its ID.
        [HttpGet("{id}")]
        public async Task<ActionResult<Student_Submissions>> GetStudentSubmission(int id)
        {
            // Primary key for Student_Submissions is Submissions_ID
            var studentSubmission = await _context.Student_Submissions.FindAsync(id);

            if (studentSubmission == null)
            {
                return NotFound();
            }

            return studentSubmission;
        }

        // POST: api/StudentSubmissions
        // Creates a new student submission.
        [HttpPost]
        public async Task<ActionResult<Student_Submissions>> PostStudentSubmission(Student_Submissions studentSubmission)
        {
            _context.Student_Submissions.Add(studentSubmission);
            await _context.SaveChangesAsync();

            // Use the correct primary key for CreatedAtAction
            return CreatedAtAction("GetStudentSubmission", new { id = studentSubmission.Submissions_ID }, studentSubmission);
        }
    }
}