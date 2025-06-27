using ISC_BE02.Models;
using ISC_BE02.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ISC_BE02.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SchoolYearController : ControllerBase
    {
        private readonly ISchoolYearService _schoolYearService;
        public SchoolYearController(ISchoolYearService schoolYearService)
        {
            _schoolYearService = schoolYearService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<SchoolYear>>> GetAll()
        {
            var results = await _schoolYearService.GetAllSchoolYearsAsync();
            return Ok(results);
        }

        [HttpPost]
        public async Task<ActionResult<SchoolYear>> Create(SchoolYear schoolYear)
        {
            var created = await _schoolYearService.CreateSchoolYearAsync(schoolYear);
            return CreatedAtAction(nameof(GetAll), new { id = created.SchoolYear_ID }, created);
        }
    }
}
