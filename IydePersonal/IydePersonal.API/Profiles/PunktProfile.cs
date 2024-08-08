﻿using AutoMapper;
using IydePersonal.API.Dtos;
using IydePersonal.API.Entities;
using IydePersonal.Core.Entities;

namespace IydePersonal.API.Profiles
{
    public class PunktProfile : Profile
    {
        public PunktProfile()
        {
            CreateMap<CreatePunktDto, Punkt>();
            CreateMap<StoreDto, Store>();
        }
    }
}
