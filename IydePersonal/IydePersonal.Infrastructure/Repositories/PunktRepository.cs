using IydePersonal.Application.Repositories;
using IydePersonal.Domain.Entities;
using IydePersonal.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace IydePersonal.Infrastructure.Repositories
{
    internal class PunktRepository : IPunktRepository
    {
        private readonly AppDbContext _appDbContext;

        public PunktRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<IEnumerable<Punkt>> GetPunktsAsync()
        {
            return await _appDbContext.Punkts.ToListAsync();
        }
    }
}
