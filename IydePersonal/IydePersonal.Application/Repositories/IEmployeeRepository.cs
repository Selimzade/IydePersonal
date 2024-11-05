using IydePersonal.Application.Dtos.Employee;
using IydePersonal.Domain.Entities;

namespace IydePersonal.Application.Repositories
{
    public interface IEmployeeRepository
    {
        public Task<IEnumerable<Employee>> GetEmployeesAsync();
        public Task<Employee> GetEmployeeById(int Id);
        public Task CreateEmployee(Employee employee);
        public Task  DeleteEmployee(int Id);
        public Task  UpdateEmplyee(int Id);

    }
}
