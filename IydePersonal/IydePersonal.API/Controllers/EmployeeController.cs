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
    public class EmployeeController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public EmployeeController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllEmployess()
        {
              var emp= await _context.Employees.ToListAsync();
              return Ok(emp);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetEmplyee(int id) 
        {
            var user=await _context.Employees.FindAsync(id);
            if (user==null)
            {
                return NotFound();
            }
            return Ok(user);
        }
        [HttpPost]
        public async Task<IActionResult> Createemployee([FromBody] EmplyeeDto emplyeeDto) 
        {
            var emp=_mapper.Map<Employee>(emplyeeDto);
            await _context.Employees.AddAsync(emp);
            await _context.SaveChangesAsync();
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> updateemplyee(int id, [FromBody] EmplyeeDto emplyeeDto)
        {
            var emp = await _context.Employees.FindAsync(id);
            if (emp == null)
            {
                return NotFound();
            }
            emp.FirstName = emplyeeDto.FirstName;
            emp.LastName = emplyeeDto.LastName;
            emp.PhoneNumber = emplyeeDto.PhoneNumber;
            emp.Gender = emplyeeDto.Gender;
            emp.DateOfBirth = emplyeeDto.DateOfBirth;
            emp.WorkPosition = emplyeeDto.WorkPosition;
            emp.Store = emplyeeDto.Store;
            emp.Active = emplyeeDto.Active;
            emp.FixSlary = emplyeeDto.FixSalary;
            emp.StartWork = emplyeeDto.StartWork;
            emp.FinishWork = emplyeeDto.FinishWork;
            _context.Employees.Update(emp);
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> deleteemplyee(int id)
        {
            var emp = await _context.Employees.FindAsync(id);
            if (emp == null)
            {
                return NotFound();
            }

            _context.Employees.Remove(emp);
            await _context.SaveChangesAsync();
            return Ok();

        }

    }
}
