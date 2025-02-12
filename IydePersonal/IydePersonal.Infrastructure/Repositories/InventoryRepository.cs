using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IydePersonal.Application.Repositories;
using IydePersonal.Domain.Entities;
using IydePersonal.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace IydePersonal.Infrastructure.Repositories
{
     public class InventoryRepository:IInventoryRepository
    {
        private readonly AppDbContext _appDbContext;
       

        public InventoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task AddInventoryAsync(Inventory inventory)
        {
            _appDbContext.Inventories.Add(inventory);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task DeleteInventoryAsync(int id)
        {
            var invertar = await _appDbContext.Inventories.FindAsync(id);
            if (invertar != null)
            {
                _appDbContext.Remove(invertar);
                await _appDbContext.SaveChangesAsync();
            }
        }

        public async Task<List<Inventory>> GetInventoriesByStoreIdAsync(int storeId)
        {

            return await _appDbContext.Inventories.Where(x=>x.StoreId==storeId).ToListAsync();
        }

        public async Task<Inventory> GetInventoryByIdAsync(int id)
        {
            return await _appDbContext.Inventories.FindAsync(id);
        }

        public async Task UpdateInventoryAsync(Inventory inventory)
        {
           _appDbContext.Inventories.Update(inventory);
            await _appDbContext.SaveChangesAsync();
        }
    }
}
