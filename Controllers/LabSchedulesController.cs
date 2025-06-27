using ISC_BE02.Models;
using ISC_BE02.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ISC_BE02.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LabSchedulesController : ControllerBase
    {
        private readonly ILabSchedulesService _labSchedulesService;
        public LabSchedulesController(ILabSchedulesService labSchedulesService)
        {
            _labSchedulesService = labSchedulesService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<LabSchedules>>> GetAll()
        {
            var results = await _labSchedulesService.GetAllLabSchedulesAsync();
            return Ok(results);
        }

        [HttpPost]
        public async Task<ActionResult<LabSchedules>> Create(LabSchedules labSchedules)
        {
            var created = await _labSchedulesService.CreateLabSchedulesAsync(labSchedules);
            return CreatedAtAction(nameof(GetAll), new { id = created.LabSchedules_ID }, created);
        }
    }
}
