using IydePersonal.API.Dtos.Punkt;

namespace IydePersonal.API.Dtos.Employee
{
    public class EmployeeDetailDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<PunktDetailDto> Punkts { get; set; }
    }
}
