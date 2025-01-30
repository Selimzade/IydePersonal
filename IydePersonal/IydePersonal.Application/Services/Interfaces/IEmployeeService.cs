using IydePersonal.Application.Dtos.Employee;
using IydePersonal.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace IydePersonal.Application.Services.Interfaces
{
    public interface IEmployeeService
    {
        public Task<IEnumerable<EmployeeDto>> GetEmployeeList();
        Task<IEnumerable<EmployeeDto>> GetAllDeleteEmployeeList();
        public Task <EmployeeDto> GetEmployeeById(int UpdateId);
        public Task<List<GetAllEmployeeforUserDto>> GetEmployeeForUser(int Id);
        public Task CreateEmployee(EmployeeAddDto employeeAddDto);
        public Task SoftDeleteEmployee(int Id, string deleteDate);
        public Task UndoDeleteEmployee(int Id);
        public Task  UpdateEmployee(EmployeeUpdateDto employeeUpdateDto);

    }
}
