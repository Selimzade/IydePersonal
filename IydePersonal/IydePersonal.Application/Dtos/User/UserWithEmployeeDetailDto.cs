using IydePersonal.Application.Dtos;

namespace IydePersonal.Application.Dtos.User
{
    public class UserWithEmployeeDetailDto
    {
        public string UserName { get; set; }
        public List<EmplyeeDto> Employees { get; set; }
    }
}
