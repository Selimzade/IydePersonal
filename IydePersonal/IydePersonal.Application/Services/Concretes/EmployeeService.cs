using AutoMapper;
using IydePersonal.Application.Dtos.Employee;
using IydePersonal.Application.Repositories;
using IydePersonal.Application.Services.Interfaces;
using IydePersonal.Domain.Entities;
using System;

namespace IydePersonal.Application.Services.Concretes
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;
       // private readonly AppDbContext _context;


        public EmployeeService(IEmployeeRepository employeeRepository, IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<EmployeeDto>> GetEmployeeList()
        {
            var employees = await _employeeRepository.GetEmployeesAsync(x=>!x.IsActive);
            var dto = _mapper.Map<IEnumerable<EmployeeDto>>(employees);
            return dto;
        }
        public async Task <EmployeeDto> GetEmployeeById(int Id)
        {
            var emp = await _employeeRepository.GetEmployeeById(Id);
            var employees= _mapper.Map<EmployeeDto>(emp);
            return employees;
        }
        public async Task CreateEmployee(EmployeeDto employeeDto)
        {
             var employees = _mapper.Map<Employee>(employeeDto);
             await _employeeRepository.CreateEmployee(employees);
        }

        public Task DeleteEmployee(int id)
        {
            var emp=_employeeRepository.DeleteEmployee(id);
            return emp;
        }


        public Task UpdateEmployee(int id)
        {
            var emp=_employeeRepository.UpdateEmplyee(id);
            return emp;
        }
    }
}
