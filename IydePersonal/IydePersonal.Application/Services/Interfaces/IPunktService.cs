using IydePersonal.Application.Dtos.Punkt;
using IydePersonal.Domain.Entities;

namespace IydePersonal.Application.Services.Interfaces
{
    public interface IPunktService
    {
        public Task<IEnumerable<PunktDetailDto>> GetPunktListAsync();
        public Task CreatePunkt(PunktAddDto punktAddDto);

        public Task  UptadePunkt(PunktUpdateDto punktUpdateDto );

        Task <PunktDetailDto> GetPunktById (int PunktId);
    }
}
