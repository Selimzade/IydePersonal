using IydePersonal.Core.Entities;

namespace IydePersonal.API.Dtos
{
    public class UserDto
    {
       // public int Id { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public List<EmplyeeDto> employees { get; set; }
    }
}
