using AutoMapper;
using IydePersonal.API.Dtos;
using IydePersonal.Core.Entities;

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
