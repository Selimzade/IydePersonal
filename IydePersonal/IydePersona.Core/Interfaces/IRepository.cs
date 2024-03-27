using IydePersonal.Core.Entities;

namespace IydePersonal.Core.Interfaces
{
    public interface IRepository : IRepositoryCore
    {
        IQueryable<Punkt> Punkts { get;}
    }
}
