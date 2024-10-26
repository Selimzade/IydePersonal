using AutoMapper;
using IydePersonal.Application.Dtos;
using IydePersonal.Application.Dtos.Employee;
using IydePersonal.Domain.Entities;

namespace IydePersonal.Application.Profiles
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<Employee, EmplyeeDto>().ReverseMap();
            CreateMap<Employee, EmployeeDetailDto>()
                .ForMember(x => x.Punkts, opts => opts.MapFrom(x => x.EmployeePunkts.Select(y => y.Punkt)));
        }
    }
}
