using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IydePersonal.Domain.Entities;

namespace IydePersonal.Application.Repositories
{
    public interface IInventoryRepository
    {
        Task<List<Inventory>> GetInventoriesByStoreIdAsync(int storeId);
        Task<Inventory> GetInventoryByIdAsync(int id);
        Task AddInventoryAsync(Inventory inventory);
        Task UpdateInventoryAsync(Inventory inventory);
        Task DeleteInventoryAsync(int id);
    }
}
