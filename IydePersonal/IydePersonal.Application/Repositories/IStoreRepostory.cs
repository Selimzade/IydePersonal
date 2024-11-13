using IydePersonal.Application.Dtos.Store;
using IydePersonal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IydePersonal.Application.Repositories
{
    public interface IStoreRepostory
    {
        public Task<List<Store>> GetAllStoreDtos();
    }
}
