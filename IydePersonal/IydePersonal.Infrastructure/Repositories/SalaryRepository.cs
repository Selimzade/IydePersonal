using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using IydePersonal.Application.Repositories;
using IydePersonal.Domain.Entities;
using IydePersonal.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace IydePersonal.Infrastructure.Repositories
{
    public class SalaryRepository:ISalaryRepository
    {
        private readonly AppDbContext _appDbContext;
        public SalaryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        private DbSet<Salary> Table { get => _appDbContext.Set<Salary>(); }
        public async Task<Salary> GetByEmployeeIdAsync(int employeeId)
        {
            return await _appDbContext.Salaries
                .FirstOrDefaultAsync(s => s.EmployeeId == employeeId);
        }
        public async Task AddAsync(Salary salary)
        {
            await _appDbContext.Salaries.AddAsync(salary);
            await _appDbContext.SaveChangesAsync();
        }
        public async Task<IEnumerable<Salary>> GetAllAsync(int employeeId)
        {
            return await _appDbContext.Salaries.Where(x => x.EmployeeId == employeeId).ToListAsync();
        }

        public async Task UpdateAsync(Salary salary)
        {
             _appDbContext.Salaries.Update(salary);
            await _appDbContext.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            var salary = await _appDbContext.Salaries.FindAsync(id);
            if (salary!=null)
            {
                _appDbContext.Salaries.Remove(salary);
                await _appDbContext.SaveChangesAsync();
            }

        }

        public async Task<IEnumerable<Salary>> GetAllAsync()
        {
            return await _appDbContext.Salaries.ToListAsync();
        }

        public async Task<IEnumerable<Salary>> GetEmployeesAsync(Expression<Func<Salary, bool>> predicate = null, params Expression<Func<Salary, object>>[] includeProperties)
        {
            IQueryable<Salary> query = Table;
            if (predicate != null)
                query = query.Where(predicate);

            if (includeProperties.Any())
                foreach (var item in includeProperties)
                    query = query.Include(item);

            return await query.ToListAsync();
            // return await _appDbContext.Employees.ToListAsync();
        }
    }
}
