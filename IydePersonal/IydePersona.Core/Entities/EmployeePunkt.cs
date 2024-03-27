namespace IydePersonal.Core.Entities
{
    public class EmployeePunkt
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int PunktId { get; set; }
        public DateTime CreateDate { get; set; }
        public Punkt punkts { get; set; }
        public Employee employees { get; set; }

    }
}
