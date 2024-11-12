using IydePersonal.Application.Repositories;
using IydePersonal.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace IydePersonal.WEB.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public async Task <IActionResult> Index()
        {
            var emp= await _employeeService.GetEmployeeList();
            return View(emp);
        }

        public async Task<IActionResult> Add() 
        {
            return View();
        }
    }
}
