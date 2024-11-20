using IydePersonal.Application.Dtos.Employee;
using IydePersonal.Domain.Entities;

namespace IydePersonal.Application.Services.Interfaces
{
    public interface IEmployeeService
    {
        public Task<IEnumerable<EmployeeDto>> GetEmployeeList();
        public Task <EmployeeDto> GetEmployeeById(int UpdateId);
        public Task CreateEmployee(EmployeeAddDto employeeAddDto);
        public Task SoftDeleteEmployee(int Id);
        public Task  UpdateEmployee(EmployeeUpdateDto employeeUpdateDto);

    }
}
