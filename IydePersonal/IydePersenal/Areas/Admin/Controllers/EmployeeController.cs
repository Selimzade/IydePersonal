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
using Microsoft.EntityFrameworkCore;
using NToastNotify;
using OfficeOpenXml;

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

        public EmployeeController(IEmployeeService employeeService, IEmployeeRepository employeeRepository, AppDbContext appDbContext, IStoryService storyService, IMapper mapper, IToastNotification toastNotification, UserManager<AppUser> userManager, IValidator<Employee> validator, IUserService userService)
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
        [Authorize(Roles = $"{RoleConsts.Superadmin},{RoleConsts.Admin}")]
       
        public async Task<IActionResult> Index()
        {
            var emp = await _employeeService.GetEmployeeList();

            return View(emp);
        }

        [HttpGet]
        public async Task<IActionResult> GetEmployeeStatistics()
        {
            var employees = await _employeeService.GetEmployeeList();

           

            if (!employees.Any())
            {
                return Json(new
                {
                    totalEmployees = 0,
                    gender = new { male = 0, female = 0 },
                    age = new { labels = new List<string>(), counts = new List<int>() },
                    position = new { labels = new List<string>(), counts = new List<int>() }
                });
            }

            var genderStats = new
            {
                male = employees.Count(e => ((byte)e.Gender==1)),
                female = employees.Count(e => ((byte)e.Gender==2))
            };

            var currentDate = DateTime.Today; // İndiki tarix
            var ageStats = employees
                 .Where(e => e.DateOfBirth != null)
                 .Select(e => new
                 {
                     Age = currentDate.Year - e.DateOfBirth.Year -
                           (e.DateOfBirth.Date > currentDate.AddYears(-(currentDate.Year - e.DateOfBirth.Year)) ? 1 : 0)
                 })
                 .Where(e => e.Age >= 18) // 🔥 Yaşı 18-dən aşağı olanları çıxarırıq!
                 .GroupBy(e => e.Age / 10 * 10)
                 .Select(g => new { AgeGroup = $"{g.Key}-{g.Key + 9}", Count = g.Count() })
                 .OrderBy(g => g.AgeGroup)
                 .ToList();

            var positionStats = employees
                .GroupBy(e => e.WorkPosition)
                .Select(g => new { Position = g.Key.ToString(), Count = g.Count() })
                .ToList();

            return Json(new
            {
                totalEmployees = employees.Count(),  // ✅ Burada Count() deyil, Count istifadə olunur
                gender = genderStats,
                age = new
                {
                    labels = ageStats.Select(a => a.AgeGroup),
                    counts = ageStats.Select(a => a.Count)
                },
                position = new
                {
                    labels = positionStats.Select(p => p.Position), // ✅ p.Position() deyil, p.Position istifadə olunmalıdır
                    counts = positionStats.Select(p => p.Count)
                }
            });
        }

        [HttpGet]
        public async Task<IActionResult> GetAllEmployeeforUser(GetAllEmployeeforUserDto getAllEmployeeforUserDto)
        {
            var user = await _userManager.GetUserAsync(User);

            if (user == null)
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
            var user = await _userService.GetAllUserList(); //_storyService.AllStoreDtos();
            return View(new EmployeeAddDto { userListDtos = user });
            //return View();
        }


        [HttpPost]
        [Authorize(Roles = $"{RoleConsts.Superadmin}")]
        public async Task<IActionResult> Add(EmployeeAddDto employeeAddDto)
        {
            var map = _mapper.Map<Employee>(employeeAddDto);
            var val = await _validator.ValidateAsync(map);
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

            var empstory = await _userService.GetAllUserList();
            empUpdatedto.userListDtos = empstory;
            return View(empUpdatedto);
        }


        [HttpPost]
        [Authorize(Roles = $"{RoleConsts.Superadmin}")]
        public async Task<IActionResult> Update(EmployeeUpdateDto employeeUpdateDto)

        {
            await _employeeService.UpdateEmployee(employeeUpdateDto);

            var empstory = await _storyService.AllStoreDtos();
            // employeeUpdateDto.stores = empstory;
            _toastNotification.AddSuccessToastMessage("Uptade Sucseccfully");
            return RedirectToAction("Index", "Employee", new { Area = "Admin" });
        }
        [Authorize(Roles = $"{RoleConsts.Superadmin}")]
        [HttpPost]
        [Route("Admin/Employee/Delete/{employeeId}")]
        public async Task<IActionResult> Delete(int employeeId, [FromBody] DeleteDate deleteDate)
        {
            await _employeeService.SoftDeleteEmployee(employeeId, deleteDate.Date );// deleteDate.Date  ile secilmis tarixi alariq
            return RedirectToAction("Index", "Employee", new { Area = "Admin" });
        }
        [Authorize(Roles = $"{RoleConsts.Superadmin}")]
        public async Task<IActionResult> UndoDelete(int UpdateId)
        {
            await _employeeService.UndoDeleteEmployee(UpdateId);
            return RedirectToAction("Index", "Employee", new { Area = "Admin" });
        }


        public async Task <IActionResult> ExportToExcel()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial; // Lisenziya ayarı
            var employees = await _employeeService.GetEmployeeList();

            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Employees");

                // Sütun başlıqlarını əlavə edirik
                //worksheet.Cells[1, 1].Value = "ID";
                worksheet.Cells[1, 1].Value = "FullName";
                worksheet.Cells[1, 2].Value = "Gender";
                worksheet.Cells[1, 3].Value = "DateOfBirth";
                worksheet.Cells[1, 4].Value = "PhoneNumber";
                worksheet.Cells[1, 5].Value = "WorkPosition";
                worksheet.Cells[1, 6].Value = "User.UserName";
                worksheet.Cells[1, 7].Value = "Address";
                worksheet.Cells[1, 8].Value = "FixSalary";
                worksheet.Cells[1, 9].Value = "StartWork";


                // Məlumatları doldururuq
                int row = 2;
                foreach (var emp in employees)
                {
                    //worksheet.Cells[row, 1].Value = emp.Id;
                    worksheet.Cells[row, 1].Value = emp.FullName;
                    worksheet.Cells[row, 2].Value = emp.Gender;
                    worksheet.Cells[row, 3].Value = emp.DateOfBirth;
                    worksheet.Cells[row, 3].Style.Numberformat.Format = "dd.mm.yyyy";
                    worksheet.Cells[row, 4].Value = emp.PhoneNumber;
                    worksheet.Cells[row, 5].Value = emp.WorkPosition;
                    worksheet.Cells[row, 6].Value = emp.User.UserName;
                    worksheet.Cells[row, 7].Value = emp.Address;
                    worksheet.Cells[row, 8].Value = emp.FixSalary;
                    worksheet.Cells[row, 9].Value = emp.StartWork;
                    worksheet.Cells[row, 9].Style.Numberformat.Format = "dd.mm.yyyy";
                    row++;
                }

                // Faylı yadda saxlamaq üçün byte massivinə çeviririk
                var stream = new MemoryStream();
                package.SaveAs(stream);
                stream.Position = 0;

                string excelName = "Employees.xlsx";
                return File(stream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", excelName);
            }
        }
    }
}
