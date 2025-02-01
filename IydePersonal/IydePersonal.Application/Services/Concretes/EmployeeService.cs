using AutoMapper;
using IydePersonal.Application.Dtos.Employee;
using IydePersonal.Application.Repositories;
using IydePersonal.Application.Services.Interfaces;
using IydePersonal.Domain.Entities;
using IydePersonal.Domain.Entities.Edentity;
using Microsoft.AspNetCore.Identity;
using System;
using System.Data;

namespace IydePersonal.Application.Services.Concretes
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;
        private readonly UserManager<AppUser> _userManager;

        //private readonly AppDbContext _context;


        public EmployeeService(IEmployeeRepository employeeRepository, IMapper mapper,UserManager<AppUser> userManager)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
          _userManager = userManager;
        }
        public async Task<IEnumerable<EmployeeDto>> GetEmployeeList()
        {
            var employees = await _employeeRepository.GetEmployeesAsync(x=>x.IsActive,x=>x.User);
            var dto = _mapper.Map<IEnumerable<EmployeeDto>>(employees);
            return dto;
        }
     

        public async Task<EmployeeDto> GetEmployeeById(int UpdateId)
        {
            var emp = await _employeeRepository.GetAsync(x=>x.IsActive&&x.Id==UpdateId,x=>x.User);
            var employees = _mapper.Map<EmployeeDto>(emp);
            return employees;
        }

        public async Task<List<GetAllEmployeeforUserDto>> GetEmployeeForUser(int Id)
        {
            var emp = await _employeeRepository.GetEmployeesAsync(x => x.IsActive);
            var map= _mapper.Map<List<GetAllEmployeeforUserDto>>(emp.Where(x=>x.UserId==Id).ToList());
            return map;
        }
        public async Task CreateEmployee(EmployeeAddDto employeeAddDto)
        {
           // var userId = 1;
            var emp = new Employee
            {
                FullName = employeeAddDto.FullName,
                //LastName = employeeAddDto.LastName,
                Gender = employeeAddDto.Gender,
                DateOfBirth = employeeAddDto.DateOfBirth,
                PhoneNumber = employeeAddDto.PhoneNumber,
                WorkPosition = employeeAddDto.WorkPosition,
              // IsActive = employeeAddDto.IsActive,
                FixSalary = employeeAddDto.FixSalary,
                Address = employeeAddDto.Address,
                UserId = employeeAddDto.UserId,
                StartWork = employeeAddDto.StartWork,
                 //= userId,

            };
            await _employeeRepository.CreateEmployee(emp);
            await _employeeRepository.SaveAsync();
        }

        public async Task SoftDeleteEmployee(int UpdateId,string deleteDate)
        {
            var emp = await _employeeRepository.GetEmployeeById(UpdateId);
            emp.IsActive = false;
            emp.FinishWork=DateTime.Parse(deleteDate);//Secilmis tarixi saxlayiriq
            await _employeeRepository.UpdateEmplyee(emp);
            await _employeeRepository.SaveAsync();
         }



        public async Task UpdateEmployee(EmployeeUpdateDto employeeUpdateDto)
        {

            var updateemp = await _employeeRepository.GetAsync(x=>x.IsActive && x.Id == employeeUpdateDto.Id);
          

            updateemp.FullName = employeeUpdateDto.FullName;
            //updateemp.LastName = employeeUpdateDto.LastName;
            updateemp.Gender = employeeUpdateDto.Gender;
            updateemp.DateOfBirth = employeeUpdateDto.DateOfBirth;
            updateemp.PhoneNumber = employeeUpdateDto.PhoneNumber;
            updateemp.WorkPosition = employeeUpdateDto.WorkPosition;
            updateemp.FixSalary = employeeUpdateDto.FixSalary;
            updateemp.Address = employeeUpdateDto.Address;
            updateemp.UserId = employeeUpdateDto.UserId;
            updateemp.StartWork = employeeUpdateDto.StartWork;

            await _employeeRepository.UpdateEmplyee(updateemp);
            await _employeeRepository.SaveAsync();


        }

        public async Task<IEnumerable<EmployeeDto>> GetAllDeleteEmployeeList()
        {
            var employees = await _employeeRepository.GetEmployeesAsync(x => !x.IsActive, x => x.User);
            var dto = _mapper.Map<IEnumerable<EmployeeDto>>(employees);
            return dto;
        }

        public async Task UndoDeleteEmployee(int Id)
        {
            var emp = await _employeeRepository.GetEmployeeById(Id);

            emp.IsActive = true;
            emp.FinishWork = null;

            await _employeeRepository.UpdateEmplyee(emp);
            await _employeeRepository.SaveAsync();
        }

       
    }
}
