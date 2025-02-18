﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IydePersonal.Domain.Entities;

namespace IydePersonal.Application.Services.Interfaces
{
    public interface ISalaryService
    {
        Task<Salary> GetSalaryByEmployeeIdAsync(int employeeId);
        Task<IEnumerable<Salary>> GetAllSalariesAsync();
        Task AddSalaryAsync(Salary salary);
        Task UpdateSalaryAsync(Salary salary);
        Task DeleteSalaryAsync(int id);
    }
}
