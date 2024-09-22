
namespace IydePersonal.API.Dtos.User
{
    public class UserWithEmployeeDetailDto
    {
        public string UserName { get; set; }
        public List<EmplyeeDto> Employees { get; set; }
    }
}
