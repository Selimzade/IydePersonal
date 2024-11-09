using IydePersonal.Application.Dtos.User;
using IydePersonal.Domain.Entities.Edentity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IydePersonal.WEB.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AuthController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public AuthController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        
        public async Task < IActionResult> Login(UserCreateDto userCreateDto)
        {
            if (ModelState.IsValid) 
            {
                var user= await _userManager.FindByNameAsync(userCreateDto.UserName);
                if (user != null)
                {
                    var result = await _signInManager.PasswordSignInAsync(user, userCreateDto.Password, userCreateDto.Rememberme, false);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Home", new { Area = "Admin" });
                    }
                    else
                    {
                        ModelState.AddModelError("", "UserName or PassWord it is wrong");
                        return View();
                    }
                }
                else
                {
                    ModelState.AddModelError("", "UserName or PassWord it is wrong");
                    return View();
                }
            }

            else
            {
                return View();
            }
           
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Logout() 
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home", new { Area = "" });
        }
    }
}
