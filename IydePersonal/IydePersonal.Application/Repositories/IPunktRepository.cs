using IydePersonal.Domain.Entities;

namespace IydePersonal.Application.Repositories
{
    public interface IPunktRepository
    {
        public Task<IEnumerable<Punkt>> GetPunktsAsync();
        public Task<Punkt> GetPunkByIdAsync( int Id);
        public Task CreatePunkt( Punkt punkt);
        public Task <Punkt> UpdatePunktAsync(Punkt punkt);
        public Task DeletePunktAsync(Punkt punkt);
        Task<int> SaveAsync();
        int Save();
    }
}
