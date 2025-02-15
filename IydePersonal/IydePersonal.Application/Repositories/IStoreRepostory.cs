using IydePersonal.Application.Dtos.Store;
using IydePersonal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IydePersonal.Application.Repositories
{
    public interface IStoreRepostory
    {
        public Task<List<Store>> GetAllStoreDtos();
        public Task CreateStore(Store store);
        Task <Store> GetStoreById(int Id);
        public Task <Store> UpdateStore (Store store);

        Task DeleteStore(Store store);
        Task<int> CountStore(Expression<Func<Store, bool>> predicate = null);
        Task<int> SaveAsync();
        int Save();
    }
}
