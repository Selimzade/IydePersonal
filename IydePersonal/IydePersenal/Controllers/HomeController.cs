using AutoMapper;
using IydePersenal.Models;
using IydePersonal.API.Controllers;
using IydePersonal.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace IydePersenal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
       
      
        private readonly IMapper _mapper;
        private readonly AppDbContext _context;

        public HomeController(ILogger<HomeController> logger,IMapper mapper, AppDbContext context)
        {
            _logger = logger;
           
            
            _mapper = mapper;
            _context = context;
        }

        [HttpGet]
        public async Task< IActionResult> Index()
        {
            var emp = await _context.Employees.ToListAsync();
            return View(emp);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
