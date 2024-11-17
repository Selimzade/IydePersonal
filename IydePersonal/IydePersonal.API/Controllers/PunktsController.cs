using IydePersonal.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace IydePersonal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PunktsController : ControllerBase
    {
        private readonly IPunktService _punktService;

        public PunktsController(IPunktService punktService)
        {
            _punktService = punktService;
        }

        [HttpGet]
        public async Task<IActionResult> GetPunks()
        {
            var punkts = await _punktService.GetPunktListAsync();
            return Ok(punkts);
        }
    }
}
