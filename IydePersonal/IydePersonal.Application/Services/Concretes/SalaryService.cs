using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IydePersonal.Application.Repositories;
using IydePersonal.Application.Services.Interfaces;
using IydePersonal.Domain.Entities;

namespace IydePersonal.Application.Services.Concretes
{
    public class SalaryService : ISalaryService
    {
        private readonly ISalaryRepository _salaryRepository;

        public SalaryService(ISalaryRepository salaryRepository)
        {
            _salaryRepository = salaryRepository;
        }

        public async Task<Salary> GetSalaryByEmployeeIdAsync(int employeeId)
        {
            return await _salaryRepository.GetByEmployeeIdAsync(employeeId);
        }

        public async Task<IEnumerable<Salary>> GetAllSalariesAsync(int employeeId)
        {
            return await _salaryRepository.GetAllAsync(employeeId);
        }

        public async Task AddSalaryAsync(Salary salary)
        {
            await _salaryRepository.AddAsync(salary);
        }

        public async Task UpdateSalaryAsync(Salary salary)
        {
            await _salaryRepository.UpdateAsync(salary);
        }

        public async Task DeleteSalaryAsync(int id)
        {
            await _salaryRepository.DeleteAsync(id);
        }

        public Task<IEnumerable<Salary>> GetAllSalariesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
