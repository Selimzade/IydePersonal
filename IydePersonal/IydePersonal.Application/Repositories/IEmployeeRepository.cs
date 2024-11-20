using IydePersonal.Application.Dtos.Employee;
using IydePersonal.Domain.Entities;
using System.Linq.Expressions;

namespace IydePersonal.Application.Repositories
{
    public interface IEmployeeRepository
    {
        public Task<IEnumerable<Employee>> GetEmployeesAsync(Expression<Func<Employee, bool>> predicate = null, params Expression<Func<Employee, object>>[] includeProperties);
        public Task<Employee> GetAsync(Expression<Func<Employee, bool>> predicate, params Expression<Func<Employee, object>>[] includeProperties);
        public Task<Employee> GetEmployeeById(int Id);
        public Task  CreateEmployee(Employee employee);
        public Task  DeleteEmployee(Employee employee);
        public Task <Employee> UpdateEmplyee(Employee employee);
        Task<int> SaveAsync();
        int Save();

    }
}
