
using IydePersonal.Application.Dtos.Punkt;

namespace IydePersonal.Application.Dtos.Employee
{
    public class EmployeeDetailDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<PunktDetailDto> Punkts { get; set; }
    }
}
