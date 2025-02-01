using AutoMapper;
using IydePersonal.Application.Dtos.Punkt;
using IydePersonal.Application.Services.Interfaces;
using IydePersonal.Domain.Entities;
using IydePersonal.WEB.Conts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IydePersonal.WEB.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PunktController : Controller
    {
        private readonly IPunktService _punktService;
        private readonly IMapper _mapper;

        public PunktController(IPunktService unktService, IMapper mapper)
        {
            _punktService = unktService;
            _mapper = mapper;
        }
        [HttpGet]
        [Authorize(Roles = $"{RoleConsts.Superadmin},{RoleConsts.Admin}")]
        public async Task<IActionResult> Index()
        {
            var punkt = await _punktService.GetPunktListAsync();
            return View(punkt);
        }

        [Authorize(Roles = $"{RoleConsts.Superadmin}")]
        public async Task<IActionResult> Add()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = $"{RoleConsts.Superadmin}")]
        public async Task<IActionResult> Add(PunktAddDto punktAddDto)
        {
            var map = _mapper.Map<Punkt>(punktAddDto);
            await _punktService.CreatePunkt(punktAddDto);
            return RedirectToAction("Index", "Punkt", new { Area = "Admin" });
        }

        [HttpGet]
        [Authorize(Roles = $"{RoleConsts.Superadmin}")]
        public async Task<IActionResult> Update(int PunktId)
        {
            var punkts = await _punktService.GetPunktById(PunktId);
            var map = _mapper.Map<PunktUpdateDto>(punkts);
            return View(map);
        }

        [HttpPost]
        [Authorize(Roles = $"{RoleConsts.Superadmin}")]
        public async Task<IActionResult> Update(PunktUpdateDto punktUpdateDto)
        {
            await _punktService.UptadePunkt(punktUpdateDto);
            return RedirectToAction("Index","Punkt",new { Area="Admin"});
        }

        [Authorize(Roles = $"{RoleConsts.Superadmin}")]
        [HttpPost]
        [Route("Admin/Punkt/Delete/{PunktId}")]
        public async Task<IActionResult> Delete(int PunktId) 
        {
            await _punktService.DeletePunkt(PunktId);
            return RedirectToAction("Index", "Punkt", new { Area = "Admin" });
        }
    }
}
