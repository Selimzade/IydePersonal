using AutoMapper;
using IydePersonal.Application.Dtos.Employee;
using IydePersonal.Application.Repositories;
using IydePersonal.Domain.Entities;
using IydePersonal.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace IydePersonal.Infrastructure.Repositories
{
    internal class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly IMapper _mapper;
        public EmployeeRepository(AppDbContext appDbContext,IMapper mapper)
        {
            _appDbContext = appDbContext;
            _mapper = mapper;
        }
        private DbSet<Employee> Table { get => _appDbContext.Set<Employee>(); }
        public async Task<IEnumerable<Employee>> GetEmployeesAsync(Expression<Func<Employee, bool>> predicate = null, params Expression<Func<Employee, object>>[] includeProperties)
        {
            IQueryable<Employee> query = Table;
            if (predicate != null)
                query = query.Where(predicate);

            if (includeProperties.Any())
                foreach (var item in includeProperties)
                    query = query.Include(item);

            return await query.ToListAsync();
           // return await _appDbContext.Employees.ToListAsync();
        }

        public async Task<Employee> GetEmployeeById(int Id)
        {
            return await _appDbContext.Employees.FindAsync(Id);
          
        }
        public async Task CreateEmployee(Employee employee)
        {
            await _appDbContext.Employees.AddAsync(employee);
        }

        public async Task DeleteEmployee(Employee employee)
        {
            await Task.Run(() => Table.Remove(employee));
        }

        public async Task <Employee> UpdateEmplyee(Employee employee)
        {
            await Task.Run(() => Table.Update(employee));
            return employee;
        }

        public Task<int> SaveAsync()
        {
           return _appDbContext.SaveChangesAsync();
        }

        public int Save()
        {
            return _appDbContext.SaveChanges();
        }

        public async Task<Employee> GetAsync(Expression<Func<Employee, bool>> predicate, params Expression<Func<Employee, object>>[] includeProperties)
        {
            IQueryable<Employee> query = Table;
            query = query.Where(predicate);

            if (includeProperties.Any())
                foreach (var item in includeProperties)
                    query = query.Include(item);

            return await query.SingleAsync();
        }
    }
}
