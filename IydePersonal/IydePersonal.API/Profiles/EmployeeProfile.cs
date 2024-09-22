using AutoMapper;
using IydePersonal.API.Dtos;
using IydePersonal.Core.Entities;

namespace IydePersonal.API.Profiles
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<Employee, EmplyeeDto>().ReverseMap();
        }
    }
}
