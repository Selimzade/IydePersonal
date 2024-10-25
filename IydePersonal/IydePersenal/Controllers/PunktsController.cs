using IydePersonal.API.Data;
using IydePersonal.WEB.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IydePersonal.WEB.Controllers
{
    public class PunktsController : Controller
    {
        private readonly AppDbContext _context;

        public PunktsController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var punkts = await _context.Punkts.ToListAsync();
            var punktsVm = punkts.Select(p => new PunktListViewModel
            {
                Id = p.Id,
                Name = p.Name,
                Point = p.Point,
            });

            return View(punktsVm);
        }
    }
}
