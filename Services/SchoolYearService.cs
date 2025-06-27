using ISC_BE02.Models;
using ISC_BE02.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ISC_BE02.Services
{
    public class SchoolYearService : ISchoolYearService
    {
        private readonly ApplicationDbContext _context;
        public SchoolYearService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<SchoolYear>> GetAllSchoolYearsAsync()
        {
            return await _context.SchoolYears.ToListAsync();
        }

        public async Task<SchoolYear> CreateSchoolYearAsync(SchoolYear schoolYear)
        {
            _context.SchoolYears.Add(schoolYear);
            await _context.SaveChangesAsync();
            return schoolYear;
        }
    }
}
