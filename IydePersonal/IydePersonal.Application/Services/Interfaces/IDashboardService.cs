using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IydePersonal.Application.Services.Interfaces
{
    public interface IDashboardService
    {
        Task<Dictionary<int, List<int>>> GetAllYearsEmployeeCount();
        Task<int> GetTotalEmployeeCounts();
        Task<int> GetDeleteTotalEmployeeCounts();
        Task <int> GetTotalStoreCounts();
        Task<int> GetTotalPunktCounts();
        Task <int> GetTotalUserCounts();
    }
}
