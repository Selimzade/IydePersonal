using IydePersonal.Domain.Entities.Edentity;
using Microsoft.AspNetCore.Identity;

namespace IydePersonal.WEB
{
    public class CustomUserValidator : IUserValidator<AppUser>
    {
        public async Task<IdentityResult> ValidateAsync(UserManager<AppUser> manager, AppUser user)
        {
            var errors = new List<IdentityError>();

            var baseValidator = new UserValidator<AppUser>();
            var baseResult = await baseValidator.ValidateAsync(manager, user);

            if (!baseResult.Succeeded)
            {
                errors.AddRange(baseResult.Errors.Where(e => e.Code != "InvalidUserName"));
            }

            if (errors.Count > 0)
            {
                return IdentityResult.Failed(errors.ToArray());
            }

            return IdentityResult.Success;
        }

    }
}
