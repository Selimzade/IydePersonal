using IydePersonal.Application.Dtos.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IydePersonal.Application.Services.Interfaces
{
    public interface IStoryService
    {
        public Task<List<StoreDto>> AllStoreDtos();
    }
}
