using ISC_BE02.Models;
using ISC_BE02.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ISC_BE02.Services
{
    public class LearningOutcomesService : ILearningOutcomesService
    {
        private readonly ApplicationDbContext _context;
        public LearningOutcomesService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<LearningOutcomes>> GetAllLearningOutcomesAsync()
        {
            return await _context.LearningOutcomes.ToListAsync();
        }

        public async Task<LearningOutcomes> CreateLearningOutcomesAsync(LearningOutcomes learningOutcomes)
        {
            _context.LearningOutcomes.Add(learningOutcomes);
            await _context.SaveChangesAsync();
            return learningOutcomes;
        }
    }
}
