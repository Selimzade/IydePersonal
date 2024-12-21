using AutoMapper;
using FluentValidation;
using FluentValidation.AspNetCore;
using IydePersonal.Application;
using IydePersonal.Application.Dtos.User;
using IydePersonal.Application.Services.Interfaces;
using IydePersonal.Domain.Entities.Edentity;
using IydePersonal.WEB.Conts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NToastNotify;
using System.Data;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Model;

namespace IydePersonal.WEB.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly IValidator<AppUser> _validator;
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        private readonly IToastNotification _toastNotification;

        public UserController(IUserService userService,IValidator<AppUser> validator, IMapper mapper, IToastNotification toastNotification)
        {
            _userService = userService;
            _mapper = mapper;
            _validator = validator;
            _toastNotification = toastNotification;
        }
        [Authorize(Roles = $"{RoleConsts.Superadmin},{RoleConsts.Admin}")]
        public async Task<IActionResult> Index()
        {
            var user = await _userService.GetAllUserList();
            //var users = await _userManager.Users.ToListAsync();
            //var map = _mapper.Map<List<UserListDto>>(users);

            //foreach (var item in map)
            //{
            //    var finduser = await _userManager.FindByIdAsync(item.Id.ToString());
            //    var role = string.Join("", await _userManager.GetRolesAsync(finduser));
            //    item.Role = role;
            //}
            //return map;
            return View(user);
        }
        [HttpGet]
        [Authorize(Roles = $"{RoleConsts.Superadmin}")]
        public async Task<IActionResult> Add()
        {
            var roles=await _userService.GetAllUserRoles();
            return View(new UserCreateDto {  Roles=roles});
        }
         
        [HttpPost]
        [Authorize(Roles = $"{RoleConsts.Superadmin}")]
        public async Task<IActionResult> Add(UserCreateDto userCreateDto)
        {
            var map = _mapper.Map<AppUser>(userCreateDto);
            var validation= await _validator.ValidateAsync(map);
            var roles = await _userService.GetAllUserRoles();
 
            var result = await _userService.CreateUserAsync(userCreateDto);
            if (result.Succeeded)
            {
                _toastNotification.AddSuccessToastMessage("Add Sucseccfully");
                return RedirectToAction("Index", "User", new { Area = "Admin" });
            }
            else
            {
                foreach (var erros in result.Errors)
                ModelState.AddModelError("", erros.Description);
                // validation.AddToModelState(this.ModelState);
                return View(new UserCreateDto { Roles = roles });
            }
        }

        [HttpGet]
        [Authorize(Roles = $"{RoleConsts.Superadmin}")]
        public async Task<IActionResult> Update(int UserId) 
        {
            var user = await _userService.GetAppUserById(UserId);
            var roles= await _userService.GetAllUserRoles();

            var map= _mapper.Map<UserEditDto>(user);
            map.Roles = roles;
            return View(map);
        }


        [HttpPost]
        [Authorize(Roles = $"{RoleConsts.Superadmin}")]
        public async Task<IActionResult> Update(UserEditDto userEditDto)
        {
            var user = await _userService.GetAppUserById(userEditDto.Id);

            if (user!=null)
            {
                    var roles = await  _userService.GetAllUserRoles();

                    _mapper.Map(userEditDto, user);
                    //user.FirstName = userEditDto.FirstName;
                    //user.LastName = userEditDto.LastName;
                    //user.UserName = userEditDto.UserName;
                
                    user.SecurityStamp = userEditDto.Id.ToString();
                    var result = await _userService.UpdateUserAsync(userEditDto);
                    if (result.Succeeded) 
                    {
                        _toastNotification.AddSuccessToastMessage("Update Sucseccfully");
                        return RedirectToAction("Index", "User", new { Area = "Admin" });
                    }
                    else
                    {
                        foreach (var erros in result.Errors)

                            ModelState.AddModelError("", erros.Description);
                        return View(new UserEditDto { Roles = roles });
                    }
            }

            return NotFound();

        }

        [Authorize(Roles = $"{RoleConsts.Superadmin}")]
        public async Task<IActionResult> Delete(int UserId)
        {
            var result = await _userService.DeleteUserAsync(UserId);            
            if (result.Succeeded)
            {
                _toastNotification.AddSuccessToastMessage("Delete Sucseccfully");
                return RedirectToAction("Index", "User", new { Area = "Admin" });
            }
            else
                foreach (var erros in result.Errors)
                    ModelState.AddModelError("", erros.Description);
            return NotFound();
        }

    }
}
