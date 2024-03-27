using IydePersonal.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IydePersonal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PunktsController : ControllerBase
    {
        private IRepository Repository { get; }

        public PunktsController(IRepository repository)
        {
            Repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPunkts()
        {
            return Ok(await Repository.Punkts.ToListAsync());
        }
    }
}
