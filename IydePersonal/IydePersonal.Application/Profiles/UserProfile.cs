using AutoMapper;
using IydePersonal.Application.Dtos.User;
using IydePersonal.Domain.Entities;
using IydePersonal.Domain.Entities.Edentity;

namespace IydePersonal.API.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<AppUser, UserListDto>().ReverseMap();
            
            CreateMap<AppUser, UserCreateDto>().ReverseMap();

            CreateMap<AppUser, UserEditDto>().ReverseMap();
            CreateMap<AppUser, UserLoginDto>().ReverseMap();
            CreateMap<AppUser, UserListDto>().ReverseMap();

            CreateMap<AppUser, UserWithEmployeeDetailDto>().ReverseMap();
        }
    }
}
