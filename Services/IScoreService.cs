using ISC_BE02.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ISC_BE02.Services
{
    public interface IScoreService
    {
        Task<IEnumerable<Score>> GetAllScoresAsync();
        Task<Score> CreateScoreAsync(Score score);
    }
}
