using ISC_BE02.Models;
using ISC_BE02.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ISC_BE02.Services
{
    public class LabSchedulesService : ILabSchedulesService
    {
        private readonly ApplicationDbContext _context;
        public LabSchedulesService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<LabSchedules>> GetAllLabSchedulesAsync()
        {
            return await _context.LabSchedules.ToListAsync();
        }

        public async Task<LabSchedules> CreateLabSchedulesAsync(LabSchedules labSchedules)
        {
            _context.LabSchedules.Add(labSchedules);
            await _context.SaveChangesAsync();
            return labSchedules;
        }
    }
}
