using IydePersonal.Application.Services.Interfaces;
using IydePersonal.WEB.Models;
using Microsoft.AspNetCore.Mvc;

namespace IydePersonal.WEB.Controllers
{
    public class PunktsController : Controller
    {
        private readonly IPunktService _punktService;

        public PunktsController(IPunktService punktService)
        {
            _punktService = punktService;
        }

        public async Task<IActionResult> Index()
        {
            var punkts = await _punktService.GetPunktListAsync();
            //var punktsVm = punkts.Select(p => new PunktListViewModel
            //{
            //    Id = p.Id,
            //    Name = p.Name,
            //    Point = p.Point,
            //});

            return View(punkts);
        }
    }
}
