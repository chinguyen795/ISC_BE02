using ISC_BE02.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ISC_BE02.Services
{
    public interface ISchoolYearService
    {
        Task<IEnumerable<SchoolYear>> GetAllSchoolYearsAsync();
        Task<SchoolYear> CreateSchoolYearAsync(SchoolYear schoolYear);
    }
}
