using AutoMapper;
using IydePersonal.Application.Dtos.User;
using IydePersonal.Domain.Entities.Edentity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using NToastNotify;

namespace IydePersonal.WEB.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;
        private readonly IMapper _mapper;
        private readonly IToastNotification _toastNotification;

        public UserController(UserManager<AppUser>userManager,RoleManager<AppRole> roleManager,IMapper mapper, IToastNotification toastNotification)
        {
           _userManager = userManager;
            _roleManager = roleManager;
            _mapper = mapper;
            _toastNotification = toastNotification;
        }
        public async Task<IActionResult> Index()
        {
            var users=await _userManager.Users.ToListAsync();
            var map= _mapper.Map<List<UserListDto>>(users);
            foreach (var item in map)
            {
                var finduser = await _userManager.FindByIdAsync(item.Id.ToString());
                var role= string.Join ( "", await _userManager.GetRolesAsync(finduser));
                item.Role = role;
            }
            return View(map);
        }

        [HttpGet]
        public async Task<IActionResult> Add() 
        {
            var roles = await _roleManager.Roles.ToListAsync();
            return View(new UserCreateDto { Roles=roles});
        }

        [HttpPost]

        public async Task <IActionResult> Add(UserCreateDto userCreateDto) 
        {
            var map = _mapper.Map<AppUser>(userCreateDto);
            var roles = await _roleManager.Roles.ToListAsync();

            if (ModelState.IsValid)
            {
                var result = await _userManager.CreateAsync(map, userCreateDto.Password);
                if (result.Succeeded)
                {
                    var findrole = await _roleManager.FindByIdAsync(userCreateDto.RoleId.ToString());
                    await _userManager.AddToRoleAsync(map, findrole.ToString());
                    _toastNotification.AddSuccessToastMessage("Add Sucseccfully");
                    return RedirectToAction("Index","User",new {area ="Admin"});
                }
                else
                {
                    foreach ( var error in result.Errors)
                        ModelState.AddModelError("", error.Description);
                    return View(new UserCreateDto { Roles = roles });

                }
            }
            return View(new UserCreateDto { Roles = roles });
        }
    }
}
