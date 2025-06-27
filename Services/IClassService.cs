using ISC_BE02.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ISC_BE02.Services
{
    public interface IClassService
    {
        Task<IEnumerable<Class>> GetAllClassesAsync();
        Task<Class> CreateClassAsync(Class classEntity);
    }
}
