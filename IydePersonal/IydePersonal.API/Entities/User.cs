using IydePersonal.API.Entities;

namespace IydePersonal.Core.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Store Store { get; set; }
    }
}
