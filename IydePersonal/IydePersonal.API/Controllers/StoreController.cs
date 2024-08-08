using AutoMapper;
using IydePersonal.API.Data;
using IydePersonal.API.Dtos;
using IydePersonal.API.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IydePersonal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public StoreController(AppDbContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet("api/GetAll")]
        public async Task<IActionResult> GetAllStores()
        {
            var store= await _context.stores.ToListAsync();
            return Ok(store);
        }
        [HttpPost("api/Create")]
        public async Task<IActionResult> CreateStore([FromBody] StoreDto storeDto) 
        {
            var store = _mapper.Map<Store>(storeDto);
            await _context.stores.AddAsync(store);
            await _context.SaveChangesAsync();
            return StatusCode(StatusCodes.Status201Created);
        }


    }
}
