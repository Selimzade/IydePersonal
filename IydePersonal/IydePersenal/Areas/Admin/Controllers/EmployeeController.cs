using AutoMapper;
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
        private readonly IMapper _mapper;


        public EmployeeController(IEmployeeService employeeService, IStoryService storyService, IMapper mapper)
        {
            _employeeService = employeeService;
            _storyService = storyService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var emp = await _employeeService.GetEmployeeList();
            return View(emp);
        }
        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var story = await _storyService.AllStoreDtos();
            return View(new EmployeeAddDto { stores = story });
        }
        [HttpPost]
        public async Task<IActionResult> Add(EmployeeAddDto employeeAddDto)
        {
            await _employeeService.CreateEmployee(employeeAddDto);
            RedirectToAction("Index", "Employee", new { Area = "Admin" });
            var story = await _storyService.AllStoreDtos();
            return View(new EmployeeAddDto { stores = story });
        }

        [HttpGet]
        public async Task<IActionResult> Update(int UpdateId)
        {
            var empupdate = await _employeeService.GetEmployeeById(UpdateId);
            var empUpdatedto = _mapper.Map<EmployeeUpdateDto>(empupdate);

            var empstory = await _storyService.AllStoreDtos();
            empUpdatedto.stores = empstory;
            return View(empUpdatedto);
        }
        [HttpPost]
        public async Task<IActionResult> Update(EmployeeUpdateDto employeeUpdateDto)
            
        {
            await  _employeeService.UpdateEmployee(employeeUpdateDto);

            var empstory = await _storyService.AllStoreDtos();
            employeeUpdateDto.stores = empstory;
            
            return View(employeeUpdateDto);
        }
    }
}
