// Controllers/ClassSessionsController.cs
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ISC_BE02.Data;
using ISC_BE02.Models;

namespace ISC_BE02.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassSessionsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ClassSessionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ClassSessions
        // Retrieves all class sessions.
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClassSessions>>> GetClassSessions()
        {
            // The DbSet name is 'ClassSessions' as defined in ApplicationDbContext
            return await _context.ClassSessions.ToListAsync();
        }

        // GET: api/ClassSessions/5
        // Retrieves a single class session by its ID.
        [HttpGet("{id}")]
        public async Task<ActionResult<ClassSessions>> GetClassSession(int id)
        {
            // Primary key for ClassSessions is Session_ID
            var classSession = await _context.ClassSessions.FindAsync(id);

            if (classSession == null)
            {
                return NotFound();
            }

            return classSession;
        }

        // POST: api/ClassSessions
        // Creates a new class session.
        [HttpPost]
        public async Task<ActionResult<ClassSessions>> PostClassSession(ClassSessions classSession)
        {
            _context.ClassSessions.Add(classSession);
            await _context.SaveChangesAsync();

            // Use the correct primary key for CreatedAtAction
            return CreatedAtAction("GetClassSession", new { id = classSession.Session_ID }, classSession);
        }
    }
}