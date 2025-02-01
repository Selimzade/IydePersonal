using IydePersonal.Application.Dtos.Employee;
using IydePersonal.Application.Services.Concretes;
using IydePersonal.Application.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Newtonsoft.Json;
using System.Globalization;

namespace IydePersonal.WEB.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]

    public class HomeController : Controller
    {
        private readonly IEmployeeService _employeeService;
        private readonly IDashboardService _dashboardService;

        public HomeController(IEmployeeService employeeService, IDashboardService dashboardService )
        {
            _employeeService = employeeService;
            _dashboardService = dashboardService;
        }
        public async Task<IActionResult> Index()
        {
            var emp = await _employeeService.GetEmployeeList();
            return View(emp);
        }
        [HttpGet]
        public async Task<JsonResult> YearlyEmployeeCounts() 
        {
            var count=await _dashboardService.GetAllYearsEmployeeCount();
            return Json(count);
        }

        [HttpGet]
        public async Task<IActionResult> TotalEmployeeCounts()
        {
            var count = await _dashboardService.GetTotalEmployeeCounts();
            return Json(count);
        }
        [HttpGet]
        public async Task<IActionResult> TotalDeleteEmployeeCounts()
        {
            var count = await _dashboardService.GetDeleteTotalEmployeeCounts();
            return Json(count);
        }

        [HttpGet]
        public async Task<IActionResult> TotalStoreCounts() 
        {
            var count= await _dashboardService.GetTotalStoreCounts();
            return Json(count);
        }

        [HttpGet]
        public async Task<IActionResult> TotalUserCounts() 
        {
            var count= await _dashboardService.GetTotalUserCounts();
            return Json(count);
        }
    }

}
