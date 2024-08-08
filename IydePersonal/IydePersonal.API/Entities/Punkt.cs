namespace IydePersonal.Core.Entities
{
    public class Punkt
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Point { get; set; }
        public List<EmployeePunkt> employeePunkts { get; set; }
        
    }
}
