namespace IydePersonal.Domain.Entities
{
    public class Punkt
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Point { get; set; }
     
        public List<EmployeePunkt> EmployeePunkts { get; set; }
        
    }
}
