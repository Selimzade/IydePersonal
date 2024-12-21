using FluentValidation;
using IydePersonal.Domain.Entities.Edentity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IydePersonal.Application.FluentValidations
{
    public class UserValidator:AbstractValidator<AppUser>
    {
        public UserValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().MinimumLength(3).MaximumLength(100);
            RuleFor(x => x.LastName).NotEmpty().MinimumLength(3).MaximumLength(100);
            RuleFor(x => x.UserName).NotEmpty().MinimumLength(3).MaximumLength(100);
        }
    }
}
