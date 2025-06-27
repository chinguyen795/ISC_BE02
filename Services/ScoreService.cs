using ISC_BE02.Models;
using ISC_BE02.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ISC_BE02.Services
{
    public class ScoreService : IScoreService
    {
        private readonly ApplicationDbContext _context;
        public ScoreService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Score>> GetAllScoresAsync()
        {
            return await _context.Score.ToListAsync();
        }

        public async Task<Score> CreateScoreAsync(Score score)
        {
            _context.Score.Add(score);
            await _context.SaveChangesAsync();
            return score;
        }
    }
}
