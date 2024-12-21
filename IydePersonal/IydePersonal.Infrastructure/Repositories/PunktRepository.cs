using IydePersonal.Application.Repositories;
using IydePersonal.Domain.Entities;
using IydePersonal.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Linq;
using System.Linq.Expressions;

namespace IydePersonal.Infrastructure.Repositories
{
    internal class PunktRepository : IPunktRepository
    {
        private readonly AppDbContext _appDbContext;
        private DbSet<Punkt> Table { get => _appDbContext.Set<Punkt>(); }
        public PunktRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task CreatePunktAsync(Punkt punkt)
        {
            await _appDbContext.Punkts.AddAsync(punkt);
        }

        public async Task<IEnumerable<Punkt>> GetPunktsAsync()
        {
            return await _appDbContext.Punkts.ToListAsync();
        }
        public  async Task<Punkt> GetPunktByIdAsync(int Id)
        {
            return await _appDbContext.Punkts.FindAsync(Id);
        }
        public async Task<Punkt> UpdatePunktAsync(Punkt punkt)
        {
            await Task.Run(() => Table.Update(punkt));
            return punkt;
        }
        public async Task DeletePunkt(Punkt punkt)
        {
              _appDbContext.Punkts.Remove(punkt);
        }
        public int Save()
        {
            return _appDbContext.SaveChanges();
        }

        public Task<int> SaveAsync()
        {
            return _appDbContext.SaveChangesAsync();
        }

        public async Task<Punkt> GetAsync(Expression<Func<Punkt, bool>> predicate, params Expression<Func<Punkt, object>>[] includeProperties)
        {
            IQueryable<Punkt> query = Table;
            query = query.Where(predicate);

            if (includeProperties.Any())
                foreach (var item in includeProperties)
                    query = query.Include(item);

            return await query.SingleAsync();
        }

        
    }
}
