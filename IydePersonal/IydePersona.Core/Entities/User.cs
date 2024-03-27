namespace IydePersonal.Core.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Employee> employees { get; set; }
    }
}
