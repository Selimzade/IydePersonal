using IydePersonal.Application.Dtos.Employee;
using IydePersonal.Domain.Entities;

namespace IydePersonal.Application.Services.Interfaces
{
    public interface IEmployeeService
    {
        public Task<IEnumerable<EmployeeDto>> GetEmployeeList();

        public Task <EmployeeDto> GetEmployeeById(int Id);
        public Task CreateEmployee(EmployeeDto employeeDto);
        public Task DeleteEmployee(int Id);
        public Task UpdateEmployee(int Id);

    }
}
