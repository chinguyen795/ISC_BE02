using ISC_BE02.Models;
using ISC_BE02.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ISC_BE02.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SubjectsController : ControllerBase
    {
        private readonly ISubjectsService _subjectsService;
        public SubjectsController(ISubjectsService subjectsService)
        {
            _subjectsService = subjectsService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Subject>>> GetAll()
        {
            var results = await _subjectsService.GetAllSubjectsAsync();
            return Ok(results);
        }

        [HttpPost]
        public async Task<ActionResult<Subject>> Create(Subject subject)
        {
            var created = await _subjectsService.CreateSubjectAsync(subject);
            return CreatedAtAction(nameof(GetAll), new { id = created.Subjects_ID }, created);
        }
    }
}
