using Microsoft.AspNetCore.Mvc;

namespace IydePersonal.WEB.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CompanyPolicy : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
