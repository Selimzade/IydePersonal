using IydePersonal.Domain.Entities.Edentity;

namespace IydePersonal.Application.Dtos.User
{
    public class UserEditDto 
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
       
        public int RoleId { get; set; }
        public IList<AppRole> Roles { get; set; }
    }
}
