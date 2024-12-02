using AutoMapper;
using IydePersonal.Application.Dtos.Punkt;
using IydePersonal.Application.Services.Interfaces;
using IydePersonal.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace IydePersonal.WEB.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PunktController : Controller
    {
        private readonly IPunktService _unktService;
        private readonly IMapper _mapper;

        public PunktController(IPunktService unktService, IMapper mapper)
        {
            _unktService = unktService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var punkt = await _unktService.GetPunktListAsync();
            return View(punkt);
        }

        public async Task<IActionResult> Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(PunktAddDto punktAddDto)
        {
            var map = _mapper.Map<Punkt>(punktAddDto);
            await _unktService.CreatePunkt(punktAddDto);
            return RedirectToAction("Index", "Punkt", new { Area = "Admin" });
        }

        [HttpGet]
        public async Task<IActionResult> Update(int PunktId)
        {
            var punkts = await _unktService.GetPunktById(PunktId);
            var map = _mapper.Map<PunktUpdateDto>(punkts);
            return View(map);
        }

        [HttpPost]
        public async Task<IActionResult> Update(PunktUpdateDto punktUpdateDto)
        {
            await _unktService.UptadePunkt(punktUpdateDto);
            return View (punktUpdateDto);
        }
    }
}
