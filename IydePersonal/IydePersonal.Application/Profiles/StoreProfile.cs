using AutoMapper;
using IydePersonal.Application.Dtos.Shop;
using IydePersonal.Application.Dtos.Store;
using IydePersonal.Domain.Entities;

namespace IydePersonal.API.Profiles
{
    public class StoreProfile : Profile
    {
        public StoreProfile()
        {
            CreateMap<Store, StoreDto>().ReverseMap();

            CreateMap<Store, StoreCreateDto>().ReverseMap();
            CreateMap<StoreDto, StoreUpdateDto>().ReverseMap();
            CreateMap<Store,StoreUpdateDto>().ReverseMap();

        }
    }
}
