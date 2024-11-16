using AutoMapper;
using IydePersonal.Application.Dtos.Employee;
using IydePersonal.Domain.Entities;

namespace IydePersonal.API.Profiles
{
    public class EmployeePunkProfile : Profile
    {
        public EmployeePunkProfile()
        {
            CreateMap<EmployeePunkt, EmployeePunktDto>().ReverseMap();
        }
    }
}
