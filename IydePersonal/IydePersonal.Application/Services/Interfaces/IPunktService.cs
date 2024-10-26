using IydePersonal.Application.Dtos.Punkt;

namespace IydePersonal.Application.Services.Interfaces
{
    public interface IPunktService
    {
        public Task<IEnumerable<PunktDetailDto>> GetPunktListAsync();
    }
}
