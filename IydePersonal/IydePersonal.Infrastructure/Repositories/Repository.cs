using IydePersonal.Core.Entities;
using IydePersonal.Core.Interfaces;
using IydePersonal.Infrastructure.Data;

namespace IydePersonal.Infrastructure.Repositories
{
    public class Repository : RepositoryCore<AppDbContext>, IRepository
    {
        public Repository(AppDbContext context) : base(context) {}

        public IQueryable<Punkt> Punkts => Context.Punkts;
    }
}
