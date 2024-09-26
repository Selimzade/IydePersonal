using AutoMapper;
using IydePersonal.API.Data;
using IydePersonal.API.Dtos.User;
using IydePersonal.Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IydePersonal.API.Controllers
{
    [Route("api/v1/[controller]")]
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
            var user = await _context.Users
               .Include(x => x.Store)
                .ToListAsync();

            var userDto = _mapper.Map<List<UserListDto>>(user);

            return Ok(userDto);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetUserById(int Id)
        {
            var user = await _context.Users
                .Include(x => x.Store)
                .FirstOrDefaultAsync(x => x.Id == Id);

            var userDto = _mapper.Map<UserListDto>(user);

            return Ok(userDto);
        }

        [HttpGet("GetUserEmployees")]
        public async Task<IActionResult> GetUserEmployees() 
        {
            var user = await _context.Users.Select(u => new { u.UserName, Store = u.Store.Name,Employee=u.Store.Employees,Punk=u.Store.Employees.Select(x=>x.EmployeePunkts.Select(x=>new { x.EmployeeId}))})



                //.Include(u => u.)//.Select(x=> new {emp=x.Employee})
                ////.ThenInclude(s => s.Employees).Select(x => x)
                .ToListAsync();

            //var userDto = _mapper.Map<List<UserWithEmployeeDetailDto>>(user);

            return Ok(user);

        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(UserCreateDto dto) 
        {
            var user = _mapper.Map<User>(dto);
            await _context.Users.AddAsync(user);
            _context.SaveChanges();
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateUsers(int id, UserEditDto dto) 
        {

            var user = await _context.Users.FindAsync(id);
            user.UserName= dto.UserName;
            user.Password= dto.Password;
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
