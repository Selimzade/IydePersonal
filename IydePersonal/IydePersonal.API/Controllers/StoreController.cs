using AutoMapper;
using IydePersonal.API.Data;
using IydePersonal.API.Dtos.Store;
using IydePersonal.API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IydePersonal.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class StoreController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public StoreController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllStores()
        {
            var store = await _context.Stores.ToListAsync();
            return Ok(store);
        }
        [HttpPost]
        public async Task<IActionResult> CreateStore(StoreCreateDto dto)
        {
            var store = _mapper.Map<Store>(dto);
            await _context.Stores.AddAsync(store);
            await _context.SaveChangesAsync();
            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpPut]
        public async Task<IActionResult> updateStores(int id, [FromBody] StoreDto storeDto) 
        {
            var store= await _context.Stores.FindAsync(id);
            store.Name = storeDto.Name;
            _context.Update(store);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteStores(int id) 
        {
            var deletestore = await _context.Stores.FindAsync(id);
            _context.Remove(deletestore);
            await _context.SaveChangesAsync();
            return BadRequest();
        }

    }
}
