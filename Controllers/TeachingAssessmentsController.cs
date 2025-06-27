// Controllers/TeachingAssessmentsController.cs
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ISC_BE02.Data;
using ISC_BE02.Models;

namespace ISC_BE02.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeachingAssessmentsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TeachingAssessmentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/TeachingAssessments
        // Retrieves all teaching assessments.
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Teaching_Assessment>>> GetTeachingAssessments()
        {
            // The DbSet name is 'Teaching_Assessment' as defined in ApplicationDbContext
            return await _context.Teaching_Assessment.ToListAsync();
        }

        // GET: api/TeachingAssessments/5
        // Retrieves a single teaching assessment by its ID.
        [HttpGet("{id}")]
        public async Task<ActionResult<Teaching_Assessment>> GetTeachingAssessment(int id)
        {
            // Primary key for Teaching_Assessment is Teaching_ID
            var teachingAssessment = await _context.Teaching_Assessment.FindAsync(id);

            if (teachingAssessment == null)
            {
                return NotFound();
            }

            return teachingAssessment;
        }

        // POST: api/TeachingAssessments
        // Creates a new teaching assessment.
        [HttpPost]
        public async Task<ActionResult<Teaching_Assessment>> PostTeachingAssessment(Teaching_Assessment teachingAssessment)
        {
            _context.Teaching_Assessment.Add(teachingAssessment);
            await _context.SaveChangesAsync();

            // Use the correct primary key for CreatedAtAction
            return CreatedAtAction("GetTeachingAssessment", new { id = teachingAssessment.Teaching_ID }, teachingAssessment);
        }
    }
}