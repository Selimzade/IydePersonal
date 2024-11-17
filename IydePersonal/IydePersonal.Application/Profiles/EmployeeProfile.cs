using AutoMapper;
using IydePersonal.Application.Dtos.Employee;
using IydePersonal.Domain.Entities;

namespace IydePersonal.Application.Profiles
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<Employee, EmployeeDto>().ReverseMap();
            CreateMap<Employee, EmployeeAddDto>().ReverseMap();
            CreateMap<Employee, EmployeeUpdateDto>().ReverseMap();
            CreateMap<EmployeeUpdateDto, EmployeeDto>().ReverseMap();
            CreateMap<Employee, EmployeeDetailDto>()
                .ForMember(x => x.Punkts, opts => opts.MapFrom(x => x.EmployeePunkts.Select(y => y.Punkt)));
        }
    }
}
