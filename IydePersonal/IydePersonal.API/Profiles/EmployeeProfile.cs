using AutoMapper;
using IydePersonal.API.Dtos;
using IydePersonal.API.Dtos.Employee;
using IydePersonal.Core.Entities;

namespace IydePersonal.API.Profiles
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
