namespace IydePersonal.Domain.Entities
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
        public bool IsActive { get; set; }=false;
        public int FixSalary { get; set; }
        public string Adress { get; set; }
        public DateTime StartWork { get; set; }=DateTime.Now;
        public DateTime? FinishWork { get; set; }

        public Store Store { get; set; }
        public int StoreId { get; set; }

        


        public User User { get; set; }
        public int UserId { get; set; }

        public List<EmployeePunkt> EmployeePunkts { get; set; } = new List<EmployeePunkt>();
        public List<Salary> Salaries { get; set; }
        public List<EmployeeLog> EmployeeLogs { get; set; }

        
    }
}
