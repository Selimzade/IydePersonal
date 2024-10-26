using IydePersonal.Application.Dtos;

namespace IydePersonal.Application.Services.Interfaces
{
    public interface IEmployeeService
    {
        public Task<IEnumerable<EmplyeeDto>> GetEmployeeList();
    }
}
