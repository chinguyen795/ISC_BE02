using ISC_BE02.Models;
using ISC_BE02.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ISC_BE02.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LearningOutcomesController : ControllerBase
    {
        private readonly ILearningOutcomesService _learningOutcomesService;
        public LearningOutcomesController(ILearningOutcomesService learningOutcomesService)
        {
            _learningOutcomesService = learningOutcomesService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<LearningOutcomes>>> GetAll()
        {
            var results = await _learningOutcomesService.GetAllLearningOutcomesAsync();
            return Ok(results);
        }

        [HttpPost]
        public async Task<ActionResult<LearningOutcomes>> Create(LearningOutcomes learningOutcomes)
        {
            var created = await _learningOutcomesService.CreateLearningOutcomesAsync(learningOutcomes);
            return CreatedAtAction(nameof(GetAll), new { id = created.LearningOutcomes_ID }, created);
        }
    }
}
