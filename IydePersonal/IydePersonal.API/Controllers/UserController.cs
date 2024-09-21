using AutoMapper;
using IydePersonal.API.Data;
using IydePersonal.API.Dtos;
using IydePersonal.Core.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IydePersonal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public UserController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetallUsers()
        {
            var user=await _context.Users.ToListAsync();
            return Ok(user);
        }
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetUserById(int id)
        {
            var user = await _context.Users.FindAsync(id);
            return Ok(user);
        }

        [HttpGet("GetUserEmployees")]
        public async Task<IActionResult> GetUserEmployees() 
        {
            var user = await _context.Users.Include(u => u.Store.Employees).Select(u => new
            {
                u.UserName,
                employees = u.Store.Employees.Select(s => new
                {
                    s.FirstName,
                    s.LastName
                })


            }).ToListAsync();

            return Ok(user);

        }
        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody]UserDto userDto) 
        {
            var user = _mapper.Map<User>(userDto);
            await _context.Users.AddAsync(user);
            _context.SaveChanges();
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateUsers(int id, [FromBody] UserDto userDto) 
        {

            var user = await _context.Users.FindAsync(id);
            user.UserName=userDto.UserName;
            user.Password=userDto.PassWord;
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteUsersP(int id) 
        {
            var user= await _context.Users.FindAsync(id, false);
            _context.Users.Remove(user);
            _context.SaveChanges();
            return Ok();
        }
            
        
    }

}
