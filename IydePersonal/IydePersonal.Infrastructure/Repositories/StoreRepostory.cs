using AutoMapper;
using IydePersonal.Application.Dtos.Store;
using IydePersonal.Application.Repositories;
using IydePersonal.Domain.Entities;
using IydePersonal.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IydePersonal.Infrastructure.Repositories
{
    public class StoreRepostory:IStoreRepostory
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        private DbSet<Store> Table { get => _context.Set<Store>(); }
        public StoreRepostory(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task CreateStore(Store store)
        {
            await _context.Stores.AddAsync(store);
        }

        public async Task<List<Store>> GetAllStoreDtos()
        {
            return await _context.Stores.ToListAsync();
        }

        public async Task<Store> GetStoreById(int Id)
        {
            return await _context.Stores.FindAsync(Id);
        }
        public async Task<Store> UpdateStore(Store store)
        {
            await Task.Run(() => Table.Update(store));
            return store;
        }

        public int Save()
        {
            return _context.SaveChanges();
        }

        public Task<int> SaveAsync()
        {
            return _context.SaveChangesAsync();
        }

        public async Task<int> CountStore(Expression<Func<Store, bool>> predicate = null)
        {
            if (predicate is not null)
                return await Table.CountAsync(predicate);
            return await Table.CountAsync();
        }

        public async Task DeleteStore(Store store)
        {
                _context.Stores.Remove(store);
        }
    }
}
