using IydePersonal.Application.Dtos.Punkt;
using IydePersonal.Domain.Entities;

namespace IydePersonal.Application.Services.Interfaces
{
    public interface IPunktService
    {
        public Task<IEnumerable<PunktDetailDto>> GetPunktListAsync();
        public Task CreatePunkt(PunktAddDto punktAddDto);
        Task<PunktDetailDto> GetPunktById(int PunktId);
        public Task  UptadePunkt(PunktUpdateDto punktUpdateDto );
        Task DeletePunkt(int PunktId);
      
    }
}
