namespace IydePersonal.Core.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }

        public List<Employee> employees { get; set; }
    }
}
