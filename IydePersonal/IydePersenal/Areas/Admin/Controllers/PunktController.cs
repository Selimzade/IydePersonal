using IydePersonal.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace IydePersonal.WEB.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PunktController : Controller
    {
       private readonly IPunktService _unktService;

        public PunktController(IPunktService unktService)
        {
            _unktService = unktService;
        }
        [HttpGet]
        public async Task <IActionResult> Index()
        {
            var punkt= await _unktService.GetPunktListAsync();
            return View(punkt);
        }
    }
}
