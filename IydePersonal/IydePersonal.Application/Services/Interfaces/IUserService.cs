using IydePersonal.Application.Dtos.User;
using IydePersonal.Domain.Entities.Edentity;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IydePersonal.Application.Services.Interfaces
{
    public interface IUserService
    {
       Task<IEnumerable<UserListDto>> GetAllUserList();
       Task<List<AppRole>> GetAllUserRoles();
       Task<IdentityResult> CreateUserAsync(UserCreateDto userCreateDto);
       Task<IdentityResult> UpdateUserAsync(UserEditDto userEditDto);
       Task <AppUser> GetAppUserById(int UserId);
       Task<string> GetUserRole(AppUser user);
       Task<IdentityResult> DeleteUserAsync(int UserId);
      
    }
}
