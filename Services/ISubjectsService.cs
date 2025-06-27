using ISC_BE02.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ISC_BE02.Services
{
    public interface ISubjectsService
    {
        Task<IEnumerable<Subject>> GetAllSubjectsAsync();
        Task<Subject> CreateSubjectAsync(Subject subject);
    }
}
