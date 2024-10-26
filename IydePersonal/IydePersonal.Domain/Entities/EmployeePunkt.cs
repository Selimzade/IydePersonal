namespace IydePersonal.Domain.Entities
{
    public class EmployeePunkt
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public int PunktId { get; set; }
        public Punkt Punkt { get; set; }
      
    }
}
