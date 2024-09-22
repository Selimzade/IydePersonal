using IydePersonal.Core.Entities;

namespace IydePersonal.API.Dtos.Store
{
    public class StoreDto
    {
        public string Name { get; set; }
        public List<EmplyeeDto> Employees { get; set; }
    }
}
