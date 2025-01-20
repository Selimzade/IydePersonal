using IydePersonal.Application.Repositories;
using IydePersonal.Application.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IydePersonal.Application.Services.Concretes
{
    public class DashboardService:IDashboardService
    {
        private readonly IEmployeeService _employeeService;
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IStoreRepostory _storeRepostory;
        private readonly IPunktRepository _punktRepository;

        public DashboardService(IEmployeeService employeeService,IEmployeeRepository employeeRepository,IStoreRepostory storeRepostory,IPunktRepository punktRepository)
        {
            _employeeService = employeeService;
            _employeeRepository = employeeRepository;
            _storeRepostory = storeRepostory;
            _punktRepository = punktRepository;
        }

        public async Task<List<int>> GetYearEmployeecount() 
        {
            var emp= await _employeeRepository.GetEmployeesAsync(x=>x.IsActive);
            var startdate= DateTime.Now;
            startdate = new DateTime(startdate.Year, 1, 1);
            List<int> datas = new();
            for (int i = 1; i<=12;i++)
            {
                var starteddate = new DateTime(startdate.Year,i,1);
                var enddate= starteddate.AddMonths(1);
                var data = emp.Where(x => x.StartWork >= starteddate && x.StartWork < enddate).Count();
                datas.Add(data);
            }
            return datas;
        }

        public async Task<int> GetTotalEmployeeCounts() 
        {
            var empcount = await _employeeRepository.CountEmployee(x=>x.IsActive);
            return empcount;
        }
        public async Task<int> GetDeleteTotalEmployeeCounts()
        {
            var empcount = await _employeeRepository.CountEmployee(x => !x.IsActive);
            return empcount;
        }

        public async Task<int> GetTotalStoreCounts()
        {
            var storecount = await _storeRepostory.CountStore();
            return storecount;
        }

        public Task<int> GetTotalPunktCounts()
        {
            var storecount = await _punktRepository.CountStore();
            return storecount;
        }
    }
}
