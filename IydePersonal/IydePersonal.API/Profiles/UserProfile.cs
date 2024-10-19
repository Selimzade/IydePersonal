using AutoMapper;
using IydePersonal.API.Dtos;
using IydePersonal.API.Dtos.User;
using IydePersonal.API.Entities;
using IydePersonal.Core.Entities;

namespace IydePersonal.API.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserListDto>().ReverseMap();
            
            CreateMap<User, UserCreateDto>().ReverseMap();

            CreateMap<User, UserEditDto>().ReverseMap();

            CreateMap<User, UserWithEmployeeDetailDto>()
                
              //.ForMember(x=>x.EmployeePunkts,opt=>opt.MapFrom(x=>x.EmployeePunkts))
               .ReverseMap();
        }
    }
}
