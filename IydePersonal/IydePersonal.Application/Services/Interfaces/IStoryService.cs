using IydePersonal.Application.Dtos.Shop;
using IydePersonal.Application.Dtos.Store;
using IydePersonal.Domain.Entities;
using Microsoft.AspNetCore.Mvc.TagHelpers.Cache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IydePersonal.Application.Services.Interfaces
{
    public interface IStoryService
    {
        public Task<List<Store>> AllStoreDtos();
        public Task AddStore(StoreCreateDto storeCreateDto);
        Task<Store> GetStoreByIdAsync(int StoreId);
        public Task UpdateStoreAsync(StoreUpdateDto storeUpdateDto);
    }
}
