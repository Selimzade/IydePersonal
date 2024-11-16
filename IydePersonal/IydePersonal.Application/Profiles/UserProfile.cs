using AutoMapper;
using IydePersonal.Application.Dtos.User;
using IydePersonal.Domain.Entities;

namespace IydePersonal.API.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserListDto>().ReverseMap();
            
            CreateMap<User, UserCreateDto>().ReverseMap();

            CreateMap<User, UserEditDto>().ReverseMap();
            CreateMap<User,UserLoginDto>().ReverseMap();

            CreateMap<User, UserWithEmployeeDetailDto>().ReverseMap();
        }
    }
}
