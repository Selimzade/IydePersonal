using IydePersenal.Models;
using IydePersonal.Application.Services.Interfaces;
using IydePersonal.WEB.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace IydePersenal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEmployeeService _employeeService;

        public HomeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public async Task< IActionResult> Index()
        {
            var employees = await _employeeService.GetEmployeeList();
            //var employeesVM = employees.Select(e => new EmployeeDetailViewModel
            //{
            //    DateOfBirth = e.DateOfBirth,
            //    FirstName = e.FirstName,
            //    LastName = e.LastName,
            //    FixSalary = e.FixSalary,
            //    Gender = e.Gender,
            //    PhoneNumber = e.PhoneNumber,
            //    StartWork = e.StartWork,
            //    WorkPosition = e.WorkPosition,
            //}).ToList();
            return View(employees);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
