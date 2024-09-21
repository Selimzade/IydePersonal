using AutoMapper;
using IydePersonal.API.Data;
using IydePersonal.API.Dtos;
using IydePersonal.API.Entities;
using IydePersonal.Core.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IydePersonal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmplyeePunkController : ControllerBase
    {
        public readonly AppDbContext _context;
        public readonly IMapper _mapper;

        public EmplyeePunkController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllEmplyeePunkt()
        {
            var emppunkt = (from e in _context.EmployeePunkts
                            join d in _context.Employees on e.EmployeeId equals d.Id
                            join x in _context.Punkts on e.PunktId equals x.Id
                            select new
                            {
                             d.FirstName,
                             x.Name,
                             x.Point,
                             e.CreateDate
                            }).ToList();
            //await _context.employeePunkts.ToListAsync();
            return Ok(emppunkt);
        }
        [HttpPost]
        public async Task<IActionResult> CreateEmplyeePunkt([FromBody] EmployeePunktDto employeePunktDto) 
        {
            var emppunktDto =  _mapper.Map<EmployeePunkt>(employeePunktDto);
            var emppunkt=await _context.EmployeePunkts.AddAsync(emppunktDto);
            await _context.SaveChangesAsync();
            return Ok(emppunkt);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateEmpployeePunkt(int id, [FromBody] EmployeePunktDto employeePunktDto)
        {
            var emppunkt=await _context.EmployeePunkts.FindAsync(id);
            emppunkt.EmployeeId=employeePunktDto.EmployeeId;
            emppunkt.PunktId=employeePunktDto.PunktId;
            emppunkt.CreateDate=employeePunktDto.CreateDate;
            _context.EmployeePunkts.Update(emppunkt);
            await _context.SaveChangesAsync();
            return Ok(emppunkt);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteEmployeePunkt(int id) 
        {
            var deleteempounkt= await _context.EmployeePunkts.FindAsync(id);
            if (deleteempounkt != null)
            {
                _context.EmployeePunkts.Remove(deleteempounkt);
            }
            await _context.SaveChangesAsync();
             return Ok(deleteempounkt);

        }
    }
}
