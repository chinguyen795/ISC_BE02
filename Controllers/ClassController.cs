using ISC_BE02.Models;
using ISC_BE02.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ISC_BE02.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClassController : ControllerBase
    {
        private readonly IClassService _classService;
        public ClassController(IClassService classService)
        {
            _classService = classService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Class>>> GetAll()
        {
            var results = await _classService.GetAllClassesAsync();
            return Ok(results);
        }

        [HttpPost]
        public async Task<ActionResult<Class>> Create(Class classEntity)
        {
            var created = await _classService.CreateClassAsync(classEntity);
            return CreatedAtAction(nameof(GetAll), new { id = created.Class_ID }, created);
        }
    }
}
