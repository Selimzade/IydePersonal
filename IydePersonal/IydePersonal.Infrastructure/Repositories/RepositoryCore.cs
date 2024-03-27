using IydePersonal.Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Data.Common;

namespace IydePersonal.Infrastructure.Repositories
{
    public class RepositoryCore<TContext> : IRepositoryCore where TContext : DbContext
    {
        public TContext Context { get; }
        public DatabaseFacade Database => Context.Database;
        public DbConnection Connection => Context.Database.GetDbConnection();

        public RepositoryCore(TContext context)
        {
            Context = context;
        }


        public void Add<TEntity>(TEntity entity) where TEntity : class
        {
            Context.Set<TEntity>().Add(entity);
        }
        public void Update<TEntity>(TEntity entity) where TEntity : class
        {
            Context.Set<TEntity>().Update(entity);
        }

        public IQueryable<TEntity> Set<TEntity>() where TEntity : class
        {
            return Context.Set<TEntity>();
        }

        public void Remove<TEntity>(TEntity entity) where TEntity : class
        {
            Context.Set<TEntity>().Remove(entity);
        }
        public void Dispose()
        {
            Context.Dispose();
        }

        public Task SaveChangesAsync()
        {
            return Context.SaveChangesAsync();
        }


    }
}
