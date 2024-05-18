using AutoMapper;
using IydePersonal.API.Data;
using IydePersonal.API.Dtos;
using IydePersonal.Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace IydePersonal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PunktsController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public PunktsController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPunkts()
        {
            return Ok(await _context.Punkts.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> CreatePunkt(CreatePunktDto createPunktDto)
        {
            var punkt=_mapper.Map<Punkt>(createPunktDto);
            await _context.Punkts.AddAsync(punkt);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
