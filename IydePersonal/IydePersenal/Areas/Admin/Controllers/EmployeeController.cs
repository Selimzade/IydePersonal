using AutoMapper;
using FluentValidation;
using FluentValidation.AspNetCore;
using IydePersonal.Application.Dtos.Employee;
using IydePersonal.Application.Repositories;
using IydePersonal.Application.Services.Interfaces;
using IydePersonal.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;

namespace IydePersonal.WEB.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;
        private readonly IStoryService _storyService;
        private readonly IMapper _mapper;
        private readonly IValidator<Employee> _validator;
        private readonly IToastNotification _toastNotification;

        public EmployeeController(IEmployeeService employeeService, IStoryService storyService, IMapper mapper, IToastNotification toastNotification, IValidator<Employee> validator)
        {
            _employeeService = employeeService;
            _storyService = storyService;
            _mapper = mapper;
            _toastNotification = toastNotification;
            _validator = validator;
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
            var map = _mapper.Map<Employee>(employeeAddDto);
            var result = await _validator.ValidateAsync(map);

            if (!result.IsValid)
            {
                result.AddToModelState(this.ModelState);
            }
            await _employeeService.CreateEmployee(employeeAddDto);
            _toastNotification.AddSuccessToastMessage("Add Sucseccfully");
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

        public async Task<IActionResult> Delete(int UpdateId) 
        {
            await  _employeeService.SoftDeleteEmployee(UpdateId);
            return  RedirectToAction("Index", "Employee", new { Area = "Admin" });
        }
    }
}
