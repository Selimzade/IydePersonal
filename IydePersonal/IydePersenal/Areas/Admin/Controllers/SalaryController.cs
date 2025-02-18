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

        public SalaryController(ISalaryService salaryService)
        {
            _salaryService = salaryService;
        }

        [HttpGet("GetSalaryByEmployee/{employeeId}")]
        public async Task<IActionResult> GetSalaryByEmployee(int employeeId)
        {
            var salary = await _salaryService.GetSalaryByEmployeeIdAsync(employeeId);
            if (salary == null)
            {
                return NotFound();
            }
            return Json(salary);  // JSON olaraq qaytarır
        }

        [HttpPost("AddSalary")]
        public async Task<IActionResult> AddSalary([FromBody] Salary salary)
        {
            if (salary == null)
            {
                return BadRequest();
            }

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

        [HttpPost("DeleteSalary/{id}")]
        public async Task<IActionResult> DeleteSalary(int id)
        {
            var existingSalary = await _salaryService.GetSalaryByEmployeeIdAsync(id);
            if (existingSalary == null)
            {
                return NotFound();
            }

            await _salaryService.DeleteSalaryAsync(id);
            return Json(new { success = true, message = "Maaş silindi." });
        }
    }
}
