using IydePersonal.Domain.Entities;

namespace IydePersonal.Application.Repositories
{
    public interface IEmployeeRepository
    {
        public Task<IEnumerable<Employee>> GetEmployeesAsync();
    }
}
