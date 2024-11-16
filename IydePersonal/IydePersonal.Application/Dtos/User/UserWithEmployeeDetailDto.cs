using IydePersonal.Application.Dtos.Employee;

namespace IydePersonal.Application.Dtos.User
{
    public class UserWithEmployeeDetailDto
    {
        public string UserName { get; set; }
        public List<EmployeeDto> Employees { get; set; }
    }
}
