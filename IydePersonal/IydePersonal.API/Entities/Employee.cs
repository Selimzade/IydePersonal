using IydePersonal.API.Entities;

namespace IydePersonal.Core.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public WorkPosition WorkPosition { get; set; }
        public bool IsActive { get; set; }
        public int FixSalary { get; set; }
        public DateTime StartWork { get; set; }
        public DateTime? FinishWork { get; set; }

        public int StoreId { get; set; }
        public Store Store { get; set; }

        public List<EmployeePunkt> EmployeePunkts { get; set; }
        public List<Salary> Salaries { get; set; }
        public List<EmployeeLog> EmployeeLogs { get; set; }
    }
}
