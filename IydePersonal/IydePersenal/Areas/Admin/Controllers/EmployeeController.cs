using AutoMapper;
using FluentValidation;
using FluentValidation.AspNetCore;
using IydePersonal.Application.Dtos.Employee;
using IydePersonal.Application.Repositories;
using IydePersonal.Application.Services.Interfaces;
using IydePersonal.Domain.Entities;
using IydePersonal.Domain.Entities.Edentity;
using IydePersonal.Infrastructure.Data;
using IydePersonal.WEB.Conts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;

namespace IydePersonal.WEB.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;
        private readonly IEmployeeRepository _employeeRepository;
        private readonly AppDbContext _appDbContext;
        private readonly IStoryService _storyService;
        private readonly IMapper _mapper;
        private readonly IValidator<Employee> _validator;
        private readonly IUserService _userService;
        private readonly IToastNotification _toastNotification;
        private readonly UserManager<AppUser> _userManager;

        public EmployeeController(IEmployeeService employeeService,IEmployeeRepository employeeRepository, AppDbContext appDbContext,IStoryService storyService, IMapper mapper, IToastNotification toastNotification, UserManager<AppUser> userManager,IValidator<Employee> validator,IUserService userService)
        {
            _employeeService = employeeService;
            _employeeRepository = employeeRepository;
            _appDbContext = appDbContext;
            _storyService = storyService;
            _mapper = mapper;
            _toastNotification = toastNotification;
            _userManager = userManager;
            _validator = validator;
            _userService = userService;
        }

        [HttpGet]
        [Authorize(Roles =$"{RoleConsts.Superadmin},{RoleConsts.Admin}")]
        public async Task<IActionResult> Index()
        {
            var emp = await _employeeService.GetEmployeeList();
            return View(emp);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllEmployeeforUser(GetAllEmployeeforUserDto getAllEmployeeforUserDto)
        {
            var user = await _userManager.GetUserAsync(User);
           
            if (user==null)
            {
                return Unauthorized();
            }
            //var emp = _appDbContext.Employees.Where(x=>x.Id==user.Id).ToList();
            //var map =   _mapper.Map<List<GetAllEmployeeforUserDto>>(emp);
            var emp = await _employeeService.GetEmployeeForUser(user.Id);
            return View(emp);
        }
        [HttpGet]
        [Authorize(Roles = $"{RoleConsts.Superadmin}")]
        public async Task<IActionResult> DeletedEmployee()
        {
            var emp = await _employeeService.GetAllDeleteEmployeeList();
            return View(emp);
        }
        
        [HttpGet]
        [Authorize(Roles = $"{RoleConsts.Superadmin}")]
        public async Task<IActionResult> Add()
        {
            var  user = await _userService.GetAllUserList(); //_storyService.AllStoreDtos();
            return View(new EmployeeAddDto { userListDtos = user });
            //return View();
        }
    
        
        [HttpPost]
        [Authorize(Roles = $"{RoleConsts.Superadmin}")]
        public async Task<IActionResult> Add(EmployeeAddDto employeeAddDto) 
        {
             var map= _mapper.Map<Employee>(employeeAddDto);
             var val= await _validator.ValidateAsync(map);
             var user = await _userService.GetAllUserList();   //story = await _storyService.AllStoreDtos();

             await _employeeService.CreateEmployee(employeeAddDto);
             _toastNotification.AddSuccessToastMessage("Add Sucseccfully");
             return RedirectToAction("index", "Employee", new { Area = "Admin" });
            
           
              //return View(new EmployeeAddDto { stores = story });
              //  return View();
             //result.AddToModelState(this.ModelState);

        }

        [HttpGet]
        [Authorize(Roles = $"{RoleConsts.Superadmin}")]
        public async Task<IActionResult> Update(int UpdateId)
        {
            var empupdate = await _employeeService.GetEmployeeById(UpdateId);
            var empUpdatedto = _mapper.Map<EmployeeUpdateDto>(empupdate);

            var empstory = await _storyService.AllStoreDtos();
            //empUpdatedto.stores = empstory;
            return View(empUpdatedto);
        }


        [HttpPost]
        [Authorize(Roles = $"{RoleConsts.Superadmin}")]
        public async Task<IActionResult> Update(EmployeeUpdateDto employeeUpdateDto)
            
        {
            await  _employeeService.UpdateEmployee(employeeUpdateDto);

            var empstory = await _storyService.AllStoreDtos();
           // employeeUpdateDto.stores = empstory;
            _toastNotification.AddSuccessToastMessage("Uptade Sucseccfully");
            return RedirectToAction("Index","Employee", new {Area="Admin"});
        }
        [Authorize(Roles = $"{RoleConsts.Superadmin}")]
        public async Task<IActionResult> Delete(int UpdateId) 
        {
            await  _employeeService.SoftDeleteEmployee(UpdateId);
            return  RedirectToAction("Index", "Employee", new { Area = "Admin" });
        }
        [Authorize(Roles = $"{RoleConsts.Superadmin}")]
        public async Task<IActionResult> UndoDelete(int UpdateId)
        {
            await _employeeService.UndoDeleteEmployee(UpdateId);
            return RedirectToAction("Index", "Employee", new { Area = "Admin" });
        }

       

    }
}
