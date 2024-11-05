//using AutoMapper;
//using IydePersonal.API.Data;
//using IydePersonal.API.Dtos;
//using IydePersonal.API.Dtos.Employee;
//using IydePersonal.Core.Entities;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;

//namespace IydePersonal.API.Controllers
//{
//    //[Route("api/[controller]")]
//    //[ApiController]
//    public class EmployeeController : ControllerBase
//    {
//        private readonly AppDbContext _context;
//        private readonly IMapper _mapper;

//        public EmployeeController(AppDbContext context, IMapper mapper)
//        {
//            _context = context;
//            _mapper = mapper;
//        }

//        //[HttpGet]
//        //public async Task<IActionResult> GetAllEmployess()
//        //{
//        //      var emp= await _context.Employees.ToListAsync();
//        //      return Ok(emp);
//        //}

//        [HttpGet("{Id}")]
//        public async Task<IActionResult> GetEmplyee(int Id) 
//        {
//            var employeeFromDb = await _context.Employees
//                .Include(x => x.EmployeePunkts)
//                .ThenInclude(x => x.Punkt)
//                .FirstOrDefaultAsync(x => x.Id == Id);

//            if (employeeFromDb == null)
//            {
//                return NotFound();
//            }

//            var employee = _mapper.Map<EmployeeDetailDto>(employeeFromDb);

//            return Ok(employee);
//        }
//        [HttpPost]
//        public async Task<IActionResult> Createemployee([FromBody] EmplyeeDto emplyeeDto) 
//        {
//            var emp = _mapper.Map<Employee>(emplyeeDto);
//            await _context.Employees.AddAsync(emp);
//            await _context.SaveChangesAsync();
//            return Ok();
//        }

//        [HttpPost("{Id}/punkt")]
//        public async Task<IActionResult> AddPunkt(int Id ,int punktId)
//        {
//            var employee = await _context.Employees.FindAsync(Id);

//            if (employee == null)
//            {
//                return NotFound();
//            }

//            employee.EmployeePunkts.Add(new EmployeePunkt { PunktId = punktId });

//            await _context.SaveChangesAsync();

//            return Ok();
//        }

//        [HttpPut]
//        public async Task<IActionResult> updateemplyee(int id, [FromBody] EmplyeeDto emplyeeDto)
//        {
//            var emp = await _context.Employees.FindAsync(id);
//            if (emp == null)
//            {
//                return NotFound();
//            }
//            emp.FirstName = emplyeeDto.FirstName;
//            emp.LastName = emplyeeDto.LastName;
//            emp.PhoneNumber = emplyeeDto.PhoneNumber;
//            emp.Gender = emplyeeDto.Gender;
//            emp.DateOfBirth = emplyeeDto.DateOfBirth;
//            emp.WorkPosition = emplyeeDto.WorkPosition;
//            emp.StoreId = emplyeeDto.StoreId;
//            emp.IsActive = emplyeeDto.Active;
//            emp.FixSalary = emplyeeDto.FixSalary;
//            emp.StartWork = emplyeeDto.StartWork;
//            emp.FinishWork = emplyeeDto.FinishWork;
//            _context.Employees.Update(emp);
//            return Ok();
//        }

//[HttpDelete]
//public async Task<IActionResult> deleteemplyee(int id)
//{
//    var emp = await _context.Employees.FindAsync(id);
//    if (emp == null)
//    {
//        return NotFound();
//    }

//    _context.Employees.Remove(emp);
//    await _context.SaveChangesAsync();
//    return Ok();

//}

//    }
//}
