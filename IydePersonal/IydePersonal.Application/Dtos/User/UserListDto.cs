using IydePersonal.Domain.Entities.Edentity;

namespace IydePersonal.Application.Dtos.User
{
    public class UserListDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }

        public string Role { get; set; }
        public int AccessFailedCount { get; set; }
        

        //public AppRole appRole { get; set; }

    }
}
