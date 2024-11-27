using AutoMapper;
using IydePersonal.Application.Dtos.Punkt;
using IydePersonal.Application.Repositories;
using IydePersonal.Application.Services.Interfaces;
using IydePersonal.Domain.Entities;

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
        public async Task CreatePunkt(PunktAddDto punktAddDto)
        {
            //var userId = 1;
            var punkt = new Punkt
            {
                Name = punktAddDto.Name,
                Point = punktAddDto.Point,

            };
            await _punktRepository.CreatePunkt(punkt);
            await _punktRepository.SaveAsync();
        }

        public Task<Punkt> GetPunktById(int id)
        {
           var punkt= _punktRepository.GetPunkByIdAsync(id);
           return punkt;
        }


        public async Task UpdatePunkt(PunktUpdateDto punktUpdateDto)
        {
            var punkt = new Punkt
            {
                Id = punktUpdateDto.Id,
                Name = punktUpdateDto.Name,
                Point = punktUpdateDto.Point,
            };
            await _punktRepository.UpdatePunktAsync(punkt);
            await _punktRepository.SaveAsync();
        }

       

        public async Task SafeDeletePunkt(int PunktId)
        {
            var punkt = await _punktRepository.GetPunkByIdAsync(PunktId);
            await _punktRepository.DeletePunktAsync(punkt);
            await _punktRepository.SaveAsync();
        }

       
    }
}
