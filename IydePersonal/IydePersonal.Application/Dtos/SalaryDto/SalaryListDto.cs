using IydePersonal.Application.Dtos.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IydePersonal.Application.Dtos.SalaryDto
{
        public class SalaryListDto
    {
        public int Id { get; set; }
        public int FixSalary { get; set; }
        public int Payment { get; set; }
        public string Sales { get; set; }
        public decimal TotalCheck { get; set; }
        public int Award { get; set; }
        public int Penalty { get; set; }
        public int Countingdown { get; set; }
        public int AdditionalBonus { get; set; }
        public int Conclusion { get; set; }
        public DateTime CreateDate { get; set; }
        public EmployeeDto employee { get; set; }

    }
}
