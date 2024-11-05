using AutoMapper;
using IydePersonal.Application.Dtos.Employee;
using IydePersonal.Application.Repositories;
using IydePersonal.Domain.Entities;
using IydePersonal.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

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
        public async Task<IEnumerable<Employee>> GetEmployeesAsync()
        {
            return await _appDbContext.Employees.ToListAsync();
        }
        public async Task<Employee> GetEmployeeById(int Id)
        {
            var emp = await _appDbContext.Employees.FindAsync(Id);
            return emp;
        }
        public async Task CreateEmployee(Employee employee)
        {
            var emp= await _appDbContext.Employees.AddAsync(employee);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task DeleteEmployee(int Id)
        {
            var emp=_appDbContext.Employees.Find(Id);

            _appDbContext.Employees.Remove(emp);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task UpdateEmplyee(int Id)
        {
            var emp = _appDbContext.Employees.Find(Id);
            if (emp==null)
            {
               
            }
            _appDbContext.Employees.Update(emp);
            await _appDbContext.SaveChangesAsync() ;
        }
    }
}
