using AutoMapper;
using IydePersonal.API.Dtos.Store;
using IydePersonal.API.Entities;

namespace IydePersonal.API.Profiles
{
    public class StoreProfile : Profile
    {
        public StoreProfile()
        {
            CreateMap<Store, StoreDto>().ReverseMap();

            CreateMap<Store, StoreCreateDto>().ReverseMap();
        }
    }
}
