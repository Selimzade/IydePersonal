using IydePersonal.Domain.Entities;

namespace IydePersonal.Application.Repositories
{
    public interface IPunktRepository
    {
        public Task<IEnumerable<Punkt>> GetPunktsAsync();
    }
}
