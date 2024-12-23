﻿using IydePersonal.Application.Dtos.Employee;
using IydePersonal.Domain.Entities;

namespace IydePersonal.Application.Services.Interfaces
{
    public interface IEmployeeService
    {
        public Task<IEnumerable<EmployeeDto>> GetEmployeeList();
        Task<IEnumerable<EmployeeDto>> GetAllDeleteEmployeeList();
        public Task <EmployeeDto> GetEmployeeById(int UpdateId);
        public Task<List<GetAllEmployeeforUserDto>> GetEmployeeForUser(int Id);
        public Task CreateEmployee(EmployeeAddDto employeeAddDto);
        public Task SoftDeleteEmployee(int Id);
        public Task UndoDeleteEmployee(int Id);
        public Task  UpdateEmployee(EmployeeUpdateDto employeeUpdateDto);

    }
}
