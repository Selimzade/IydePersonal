using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using IydePersonal.Domain.Entities;

namespace IydePersonal.Application.Repositories
{
   public interface ISalaryRepository
    {
        Task<Salary> GetByEmployeeIdAsync(int employeeId);
        Task<IEnumerable<Salary>> GetAllAsync(int employeeId);
        public Task<IEnumerable<Salary>> GetEmployeesAsync(Expression<Func<Salary, bool>> predicate = null, params Expression<Func<Salary, object>>[] includeProperties);
        Task<IEnumerable<Salary>> GetAllAsync();
        Task AddAsync(Salary salary);
        Task UpdateAsync(Salary salary);
        Task DeleteAsync(int id);
        
    }
}
