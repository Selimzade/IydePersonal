using AutoMapper;
using IydePersonal.Application.Dtos;
using IydePersonal.Application.Repositories;
using IydePersonal.Application.Services.Interfaces;

namespace IydePersonal.Application.Services.Concretes
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;

        public EmployeeService(IEmployeeRepository employeeRepository, IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<EmplyeeDto>> GetEmployeeList()
        {
            var employees = await _employeeRepository.GetEmployeesAsync();
            var dto = _mapper.Map<IEnumerable<EmplyeeDto>>(employees);
            return dto;
        }
    }
}
