﻿using AutoMapper;
using IydePersonal.API.Dtos;
using IydePersonal.Core.Entities;

namespace IydePersonal.API.Profiles
{
    public class PunktProfile : Profile
    {
        public PunktProfile()
        {
            CreateMap<Punkt, CreatePunktDto>().ReverseMap();
        }
    }
}
