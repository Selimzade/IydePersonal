namespace IydePersonal.Core.Entities
{
    public class Employee
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string WorkPosition { get; set; }
        public string shop { get; set; }
        public bool Active { get; set; }
        public int SalaryId { get; set; }
        public DateTime StartWork { get; set; }
        public DateTime FinishWork { get; set; }
        public int UserId { get; set; }
        public List<EmployeePunkt> employeePunkts { get; set; }
        public Salary Salary { get; set; }

        public User Users { get; set; }



    }
}
