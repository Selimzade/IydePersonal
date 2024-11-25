using IydePersonal.Domain.Entities;

namespace IydePersonal.Application.Repositories
{
    public interface IPunktRepository
    {
        public Task<IEnumerable<Punkt>> GetPunktsAsync();
        public Task CreatePunkt( Punkt punkt);
        Task<int> SaveAsync();
        int Save();
    }
}
