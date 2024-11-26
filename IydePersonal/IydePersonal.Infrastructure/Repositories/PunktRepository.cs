using AutoMapper;
using IydePersonal.Application.Repositories;
using IydePersonal.Domain.Entities;
using IydePersonal.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace IydePersonal.Infrastructure.Repositories
{
    internal class PunktRepository : IPunktRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly IMapper _mapper;

        public PunktRepository(AppDbContext appDbContext,IMapper mapper)
        {
            _appDbContext = appDbContext;
            _mapper = mapper;
        }

        public async Task<IEnumerable<Punkt>> GetPunktsAsync()
        {
            return await _appDbContext.Punkts.ToListAsync();
        }

        public async Task<Punkt> GetPunkByIdAsync(int Id)
        {
            return await _appDbContext.Punkts.FindAsync(Id);
        }

        public async Task CreatePunkt(Punkt punkt)
        {
            await _appDbContext.Punkts.AddAsync(punkt);
        }
        public async Task <Punkt> UpdatePunktAsync(Punkt punkt)
        {
             var punk=  _appDbContext.Punkts.Update(punkt);
             return punkt;
        }
        public async Task DeletePunktAsync(Punkt punkt)
        {
             _appDbContext.Remove(punkt);
        }

        public int Save()
        {
            return _appDbContext.SaveChanges();
        }

        public Task<int> SaveAsync()
        {
           return _appDbContext.SaveChangesAsync();
        }

       
    }
}
