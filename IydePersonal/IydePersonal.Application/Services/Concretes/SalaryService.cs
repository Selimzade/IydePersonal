using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using IydePersonal.Application.Dtos.SalaryDto;
using IydePersonal.Application.Repositories;
using IydePersonal.Application.Services.Interfaces;
using IydePersonal.Domain.Entities;

namespace IydePersonal.Application.Services.Concretes
{
    public class SalaryService : ISalaryService
    {
        private readonly ISalaryRepository _salaryRepository;
        private readonly IMapper _mapper;

        public SalaryService(ISalaryRepository salaryRepository,IMapper mapper)
        {
            _salaryRepository = salaryRepository;
            _mapper = mapper;
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

        public async Task<IEnumerable<SalaryListDto>> GetAllSalariesAsync()
        {
            var salary= await _salaryRepository.GetEmployeesAsync(null, x=>x.Employee);
            var map = _mapper.Map<IEnumerable<SalaryListDto>>(salary);
            return map;
        }
    }
}
