namespace IydePersonal.Core.Entities
{
    public class Salary
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int FixSalary { get; set; }
        public int Payment { get; set; }
        public decimal Sales { get; set; }
        public decimal TotalCheck { get; set; }
        public int Award { get; set; }
        public int Penalty { get; set; }
        public int Countingdown { get; set; }
        public int AdditionalBonus { get; set; }
        public int Conclusion { get; set; }
        public DateTime CreateDate { get; set; }
        public Employee employees { get; set; }
    }
}
