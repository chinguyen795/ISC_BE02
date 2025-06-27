// Controllers/AssignmentsController.cs
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ISC_BE02.Data;
using ISC_BE02.Models;

namespace ISC_BE02.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssignmentsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AssignmentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Assignments
        // Retrieves all assignments.
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Assignment>>> GetAssignments()
        {
            // The DbSet name is 'Assignments' as defined in ApplicationDbContext
            return await _context.Assignments.ToListAsync();
        }

        // GET: api/Assignments/5
        // Retrieves a single assignment by its ID.
        [HttpGet("{id}")]
        public async Task<ActionResult<Assignment>> GetAssignment(int id)
        {
            // Primary key for Assignment is Assignment_ID
            var assignment = await _context.Assignments.FindAsync(id);

            if (assignment == null)
            {
                return NotFound();
            }

            return assignment;
        }

        // POST: api/Assignments
        // Creates a new assignment.
        [HttpPost]
        public async Task<ActionResult<Assignment>> PostAssignment(Assignment assignment)
        {
            _context.Assignments.Add(assignment);
            await _context.SaveChangesAsync();

            // Use the correct primary key for CreatedAtAction
            return CreatedAtAction("GetAssignment", new { id = assignment.Assignment_ID }, assignment);
        }
    }
}