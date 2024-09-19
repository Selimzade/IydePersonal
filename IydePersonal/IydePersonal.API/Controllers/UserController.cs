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
            var user=await _context.users.ToListAsync();
            return Ok(user);
        }
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetUserById(int id)
        {
            var user = await _context.users.FindAsync(id);
            return Ok(user);
        }

        [HttpGet("GetUserEmployees")]
        public async Task<IActionResult> GetUserEmployees() 
        {
            var user = await _context.users.Include(u => u.employees).Select(u => new
            {
                u.UserName,
                employees = u.employees.Select(s => new
                {
                    s.FirstName,
                    s.LastName
                })


            }).ToListAsync();

            //  var userdto = _mapper.Map<UserDto>(user);
            return Ok(user);

        }
        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody]UserDto userDto) 
        {
            var user = _mapper.Map<User>(userDto);
            await _context.users.AddAsync(user);
            _context.SaveChanges();
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateUsers(int id, [FromBody] UserDto userDto) 
        {

            var user = await _context.users.FindAsync(id);
            user.UserName=userDto.UserName;
            user.PassWord=userDto.PassWord;
            _context.users.Update(user);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteUsersP(int id) 
        {
            var user= await _context.users.FindAsync(id, false);
            _context.users.Remove(user);
            _context.SaveChanges();
            return Ok();
        }
            
        
    }

}
