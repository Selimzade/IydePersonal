
using IydePersonal.API.Entities;
using IydePersonal.Core.Entities;

namespace IydePersonal.API.Dtos.User
{
    public class UserWithEmployeeDetailDto
    {
        public string UserName { get; set; }
        public List<EmplyeeDto> Employees { get; set; }
        //public List<EmployeePunktDto> EmployeePunkts { get; set; }

    }
}
