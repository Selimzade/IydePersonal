using IydePersonal.Application.Dtos.Employee;
using IydePersonal.Application.Repositories;
using IydePersonal.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace IydePersonal.WEB.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;
        private readonly IStoryService _storyService;

        public EmployeeController(IEmployeeService employeeService, IStoryService storyService)
        {
            _employeeService = employeeService;
            _storyService = storyService;
        }

        [HttpGet]
        public async Task <IActionResult> Index()
        {
            var emp= await _employeeService.GetEmployeeList();
            return View(emp);
        }
        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var story = await _storyService.AllStoreDtos();
            return View(new EmployeeAddDto { stores=story });
        }
        [HttpPost]
        public async Task<IActionResult> Add(EmployeeAddDto employeeAddDto)
        {
            await _employeeService.CreateEmployee(employeeAddDto);
            RedirectToAction("Index","Employee", new { Area="Admin"});
            var story = await _storyService.AllStoreDtos();
            return View(new EmployeeAddDto { stores = story });
        }
    }
}
