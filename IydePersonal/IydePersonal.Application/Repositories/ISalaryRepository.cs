using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IydePersonal.Domain.Entities;

namespace IydePersonal.Application.Repositories
{
   public interface ISalaryRepository
    {
        Task<Salary> GetByEmployeeIdAsync(int employeeId);
        Task<IEnumerable<Salary>> GetAllAsync(int employeeId);
        Task AddAsync(Salary salary);
        Task UpdateAsync(Salary salary);
        Task DeleteAsync(int id);
        
    }
}
