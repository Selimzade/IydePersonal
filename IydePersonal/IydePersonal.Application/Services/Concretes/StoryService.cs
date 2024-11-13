using AutoMapper;
using IydePersonal.Application.Dtos.Store;
using IydePersonal.Application.Repositories;
using IydePersonal.Application.Services.Interfaces;
using IydePersonal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IydePersonal.Application.Services.Concretes
{
    public class StoryService:IStoryService
    {
        private readonly IStoreRepostory _storeRepostory;
        private readonly IMapper _mapper;

        public StoryService(IStoreRepostory storeRepostory, IMapper mapper)
        {
            _storeRepostory = storeRepostory;
            _mapper = mapper;
        }

        public async Task<List<StoreDto>> AllStoreDtos()
        {
            var story=await _storeRepostory.GetAllStoreDtos();
            var map = _mapper.Map<List<StoreDto>>(story);
            return map;
        }
    }
}
