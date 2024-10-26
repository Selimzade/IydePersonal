using AutoMapper;
using IydePersonal.Application.Dtos.Punkt;
using IydePersonal.Application.Repositories;
using IydePersonal.Application.Services.Interfaces;

namespace IydePersonal.Application.Services.Concretes
{
    internal class PunktService : IPunktService
    {
        private readonly IPunktRepository _punktRepository;
        private readonly IMapper _mapper;

        public PunktService(IPunktRepository punktRepository, IMapper mapper)
        {
            _punktRepository = punktRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<PunktDetailDto>> GetPunktListAsync()
        {
            var punkts = await _punktRepository.GetPunktsAsync();
            var dto = _mapper.Map<IEnumerable<PunktDetailDto>>(punkts);
            return dto;
        }
    }
}
