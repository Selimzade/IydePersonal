namespace IydePersonal.Core.Entities
{
    public class Salary
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int SalaryId { get; set; }
        public decimal StorePercent { get; set; }
        public decimal Generalcheck { get; set; }
        public int Award { get; set; }
        public int Penalty { get; set; }
        public int Countingdown { get; set; }
        public int Conclusion { get; set; }
        public List<Employee> employees { get; set; }


    }
}
