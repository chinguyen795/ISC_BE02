using ISC_BE02.Models;
using ISC_BE02.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ISC_BE02.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ScoreController : ControllerBase
    {
        private readonly IScoreService _scoreService;
        public ScoreController(IScoreService scoreService)
        {
            _scoreService = scoreService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Score>>> GetAll()
        {
            var scores = await _scoreService.GetAllScoresAsync();
            return Ok(scores);
        }

        [HttpPost]
        public async Task<ActionResult<Score>> Create(Score score)
        {
            var createdScore = await _scoreService.CreateScoreAsync(score);
            return CreatedAtAction(nameof(GetAll), new { id = createdScore.Score_ID }, createdScore);
        }
    }
}
