using AutoMapper;
using IydePersonal.Application.Dtos.Shop;
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

        public async Task AddStore(StoreCreateDto storeCreateDto)
        {
            var store = new Store
            {
                Name = storeCreateDto.Name
            };
          await  _storeRepostory.CreateStore(store);
          await  _storeRepostory.SaveAsync();
        }

        public async Task<List<Store>> AllStoreDtos()
        {
            var story=await _storeRepostory.GetAllStoreDtos();
           // var map = _mapper.Map<List<StoreDto>>(story);
            return story;
        }

        public async Task<Store> GetStoreByIdAsync(int StoreId)
        {
           var store= await _storeRepostory.GetStoreById(StoreId);
           //var map=  _mapper.Map<StoreDto>(store);
           return store;
        }

        public async Task UpdateStoreAsync(StoreUpdateDto storeUpdateDto)
        {
            var map =  _mapper.Map<Store>(storeUpdateDto);
            var store = await _storeRepostory.UpdateStore(map);

            store.Id = storeUpdateDto.Id;
            store.Name = storeUpdateDto.Name;

            await _storeRepostory.UpdateStore(store);
            await _storeRepostory.SaveAsync();
        }
    }
}
