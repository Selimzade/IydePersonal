using IydePersonal.Domain.Entities.Edentity;

namespace IydePersonal.Application.Dtos.User
{
    public class UserCreateDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }

        public string Password { get; set; }
        public int RoleId { get; set; }
        public List<AppRole> Roles { get; set; }
       
        
    }
}
