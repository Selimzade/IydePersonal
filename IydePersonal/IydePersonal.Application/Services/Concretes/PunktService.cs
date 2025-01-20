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

        public async Task CreatePunkt(PunktAddDto punktAddDto)
        {
            var punk = new Punkt
            {
               Name = punktAddDto.Name,
               Point = punktAddDto.Point,
            };
           await _punktRepository.CreatePunktAsync(punk);
           await  _punktRepository.SaveAsync();
        }

        public async Task DeletePunkt(int PunktId)
        {
            var emp= await _punktRepository.GetPunktByIdAsync(PunktId);
            await _punktRepository.DeletePunkt(emp);
            await _punktRepository.SaveAsync(); 

        }

        public async Task<PunktDetailDto> GetPunktById(int PunktId)
        {
            var punkt = await _punktRepository.GetPunktByIdAsync(PunktId);
            var map = _mapper.Map<PunktDetailDto>(punkt);
            return map;
        }

        public async Task<IEnumerable<PunktDetailDto>> GetPunktListAsync()
        {
            var punkts = await _punktRepository.GetPunktsAsync();
            var dto = _mapper.Map<IEnumerable<PunktDetailDto>>(punkts);
            return dto;
        }

        public async Task UptadePunkt(PunktUpdateDto punktUpdateDto)
        {
            var punk = _mapper.Map<Punkt>(punktUpdateDto);
            var map = await _punktRepository.UpdatePunktAsync(punk);

            map.Id = punktUpdateDto.Id;
            map.Name = punktUpdateDto.Name;
            map.Point = punktUpdateDto.Point;

            await _punktRepository.UpdatePunktAsync(map);
            await _punktRepository.SaveAsync();
            
        }

       
    }
}
