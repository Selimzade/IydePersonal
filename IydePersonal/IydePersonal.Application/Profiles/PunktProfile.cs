using AutoMapper;
using IydePersonal.Application.Dtos;
using IydePersonal.Application.Dtos.Punkt;
using IydePersonal.Domain.Entities;


namespace IydePersonal.API.Profiles
{
    public class PunktProfile : Profile
    {
        public PunktProfile()
        {
            CreateMap<Punkt, CreatePunktDto>().ReverseMap();
            CreateMap<Punkt, PunktDetailDto>().ReverseMap();
        }
    }
}
