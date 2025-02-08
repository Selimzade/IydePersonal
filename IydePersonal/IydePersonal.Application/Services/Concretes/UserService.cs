using AutoMapper;
using IydePersonal.Application.Dtos.User;
using IydePersonal.Application.Services.Interfaces;
using IydePersonal.Domain.Entities.Edentity;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IydePersonal.Application.Services.Concretes
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;

        public UserService(IMapper mapper,UserManager<AppUser> userManager,RoleManager<AppRole> roleManager) 
        {
            _mapper = mapper;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<IdentityResult> CreateUserAsync(UserCreateDto userCreateDto)
        {
            var map=_mapper.Map<AppUser>(userCreateDto);
            var result=await _userManager.CreateAsync(map,userCreateDto.Password);
            if (result.Succeeded)
            {
                var findrole = await _roleManager.FindByIdAsync(userCreateDto.RoleId.ToString());
                await _userManager.AddToRoleAsync(map, findrole.ToString());
                return result;
            }
            else return result;
        }

      
        public  async Task<List<UserListDto>> GetAllUserList()
        {
            var users =  _userManager.Users.ToList();  //burda Tolistasync qebule elemedi
            var map = _mapper.Map<List<UserListDto>>(users);

            foreach (var item in map)
            {
                var finduser = await _userManager.FindByIdAsync(item.Id.ToString());
                var role = string.Join("", await _userManager.GetRolesAsync(finduser));
                item.Role = role;
            }
            return map;
        }

        public async Task<List<AppRole>> GetAllUserRoles()
        {
           return  _roleManager.Roles.ToList();
        }

        public async Task<AppUser> GetAppUserById(int UserId)
        {
            return await _userManager.FindByIdAsync(UserId.ToString());
        }

        public async Task<string> GetUserRole(AppUser user)
        {
            return string.Join("", await _userManager.GetRolesAsync(user));
        }

        public async Task<IdentityResult> UpdateUserAsync(UserEditDto userEditDto)
        {
            var user=await GetAppUserById(userEditDto.Id);
            var role = await GetUserRole(user);
            var result=await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {

                if (!string.IsNullOrEmpty(userEditDto.NewPassword)) 
                {
                    var token = await _userManager.GeneratePasswordResetTokenAsync(user);
                    var passwordchange = await _userManager.ResetPasswordAsync(user, token, userEditDto.NewPassword);
                    if (!passwordchange.Succeeded)
                        return passwordchange;
                } 
                await _userManager.RemoveFromRoleAsync(user,role);
                var findrole = await _roleManager.FindByIdAsync(userEditDto.RoleId.ToString());
                await _userManager.AddToRoleAsync(user, findrole.Name);
                return result;
            }
            else return result;
        }
        public async Task<IdentityResult> DeleteUserAsync(int UserId)
        {
            var user = await GetAppUserById(UserId);
            var result= await _userManager.DeleteAsync(user);
            if (result.Succeeded)
                return result;
            else return result;
        }

    }
}
