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
        private readonly IUserRepository _userRepository;
        

        public DashboardService(IEmployeeService employeeService,IEmployeeRepository employeeRepository,IStoreRepostory storeRepostory,IPunktRepository punktRepository,IUserRepository userRepository)
        {
            _employeeService = employeeService;
            _employeeRepository = employeeRepository;
            _storeRepostory = storeRepostory;
            _punktRepository = punktRepository;
            _userRepository = userRepository;
            
        }

        public async Task<Dictionary<int, List<int>>> GetAllYearsEmployeeCount()
        {
            var emp= await _employeeRepository.GetEmployeesAsync(x=>x.IsActive);

            ////var startdate= DateTime.Now;
            //var startdate = new DateTime(year, 1, 1);
            //List<int> datas = new();
            //for (int i = 1; i<=12;i++)
            //{
            //    var starteddate = new DateTime(startdate.Year,i,1);
            //    var enddate= starteddate.AddMonths(1);
            //    var data = emp.Where(x => x.StartWork >= starteddate && x.StartWork < enddate).Count();
            //    datas.Add(data);
            //}
            //return datas;

            if (!emp.Any()) return new Dictionary<int, List<int>>();

            int minYear = emp.Min(x => x.StartWork.Year); // Ən köhnə işçinin başladığı il
            int maxYear = DateTime.Now.Year; // Cari il
            Dictionary<int, List<int>> yearlyData = new();

            for (int year = minYear; year <= maxYear; year++)
            {
                List<int> monthlyCounts = new();

                for (int i = 1; i <= 12; i++)
                {
                    var starteddate = new DateTime(year, i, 1);
                    var enddate = starteddate.AddMonths(1);
                    var count = emp.Where(x => x.StartWork >= starteddate && x.StartWork < enddate).Count();
                    monthlyCounts.Add(count);
                }

                yearlyData.Add(year, monthlyCounts);
            }

            return yearlyData;
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

        public async Task<int> GetTotalPunktCounts()
        {
            var storecount = await _punktRepository.CountStore();
            return storecount;
        }

        public async Task<int> GetTotalUserCounts()
        {
           var usercount= await _userRepository.CountUser();
           return usercount;
        }
    }
}
