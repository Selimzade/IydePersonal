using IydePersonal.Application.Dtos.Employee;
using IydePersonal.Domain.Entities;

namespace IydePersonal.Application.Dtos.Store
{
    public class StoreDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Inventory> inventories { get; set; }

        //  public List<EmployeeDto> Employees { get; set; }
    }
}
