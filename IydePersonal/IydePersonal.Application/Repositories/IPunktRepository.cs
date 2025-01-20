using IydePersonal.Domain.Entities;
using System.Linq.Expressions;

namespace IydePersonal.Application.Repositories
{
    public interface IPunktRepository
    {
        public Task<IEnumerable<Punkt>> GetPunktsAsync();
        public Task<Punkt> GetAsync(Expression<Func<Punkt, bool>> predicate, params Expression<Func<Punkt, object>>[] includeProperties);
        public Task CreatePunktAsync(Punkt punkt);
        public Task <Punkt> UpdatePunktAsync (Punkt punkt);
        Task <Punkt> GetPunktByIdAsync(int Id);
        Task DeletePunkt(Punkt punkt);
        Task<int> CountStore(Expression<Func<Punkt, bool>> predicate = null);
        Task<int> SaveAsync();
        int Save();
    }
}
