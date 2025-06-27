using ISC_BE02.Models;
using ISC_BE02.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ISC_BE02.Services
{
    public class SubjectsService : ISubjectsService
    {
        private readonly ApplicationDbContext _context;
        public SubjectsService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Subject>> GetAllSubjectsAsync()
        {
            return await _context.Subjects.ToListAsync();
        }

        public async Task<Subject> CreateSubjectAsync(Subject subject)
        {
            _context.Subjects.Add(subject);
            await _context.SaveChangesAsync();
            return subject;
        }
    }
}
