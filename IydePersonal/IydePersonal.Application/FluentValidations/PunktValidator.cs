using FluentValidation;
using IydePersonal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IydePersonal.Application.FluentValidations
{
   public class PunktValidator : AbstractValidator<Punkt>
    {
        public PunktValidator()
        {
            RuleFor(x => x.Name).NotEmpty().NotNull();
            RuleFor(x => x.Point).NotEmpty().NotNull();
        }
    }
}
