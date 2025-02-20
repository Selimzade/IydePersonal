using IydePersonal.Application.Repositories;
using IydePersonal.Application.Services.Interfaces;
using IydePersonal.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace IydePersonal.WEB.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Salary")]
    public class SalaryController : Controller
    {
        private readonly ISalaryService _salaryService;
        private readonly ISalaryRepository _salaryRepository;

        public SalaryController(ISalaryService salaryService,ISalaryRepository salaryRepository)
        {
            _salaryService = salaryService;
            _salaryRepository = salaryRepository;
        }

        [HttpGet("GetSalaryByEmployee")]
        public async Task<IActionResult> GetSalaryByEmployee(int employeeId)
        {
            if (employeeId == 0)
            {
                return BadRequest("Employee ID null və ya 0-dır.");
            }

            var salaries = await _salaryRepository.GetAllAsync(employeeId);
            if (salaries == null || !salaries.Any())
            {
                return NotFound("Maaş məlumatı tapılmadı.");
            }

            return Json(salaries);
        }

        [HttpPost("AddSalary")]
        public async Task<IActionResult> AddSalary([FromBody] Salary salary)
        {
            await _salaryService.AddSalaryAsync(salary);
            return Json(new { success = true, message = "Maaş əlavə edildi." });
        }

        [HttpPost("UpdateSalary")]
        public async Task<IActionResult> UpdateSalary([FromBody] Salary salary)
        {
            if (salary == null)
            {
                return BadRequest();
            }

            var existingSalary = await _salaryService.GetSalaryByEmployeeIdAsync(salary.EmployeeId);
            if (existingSalary == null)
            {
                return NotFound();
            }

            await _salaryService.UpdateSalaryAsync(salary);
            return Json(new { success = true, message = "Maaş yeniləndi." });
        }

        [HttpPost("DeleteSalary")]
        public async Task<IActionResult> DeleteSalary(int id,int employeeId)
        {
            //var existingSalary = await _salaryService.GetSalaryByEmployeeIdAsync(id);
            if (id == 0)
            {
                return NotFound();
            }

            await _salaryService.DeleteSalaryAsync(id);
        }
    }
}
