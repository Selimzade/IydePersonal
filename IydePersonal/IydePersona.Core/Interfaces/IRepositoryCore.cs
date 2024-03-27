namespace IydePersonal.Core.Interfaces
{
    public interface IRepositoryCore : IDisposable
    {
        void Add<TEntity>(TEntity entity) where TEntity : class;

        void Update<TEntity>(TEntity entity) where TEntity : class;

        void Remove<TEntity>(TEntity entity) where TEntity : class;

        IQueryable<TEntity> Set<TEntity>() where TEntity : class;

        Task SaveChangesAsync();
    }
}
