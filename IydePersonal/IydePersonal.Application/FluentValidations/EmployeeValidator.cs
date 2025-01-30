using FluentValidation;
using IydePersonal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IydePersonal.Application.FluentValidations
{
    public class EmployeeValidator:AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
            RuleFor(x => x.FullName).NotEmpty().NotNull().MinimumLength(3).MaximumLength(100);
            //RuleFor(x => x.LastName).NotEmpty().NotNull().MinimumLength(3).MaximumLength(100);
            RuleFor(x => x.Gender).NotEmpty().NotNull();
            RuleFor(x => x.DateOfBirth).NotEmpty().NotNull();
            RuleFor(x => x.PhoneNumber).NotEmpty().NotNull();
            RuleFor(x => x.WorkPosition).NotEmpty().NotNull();
            RuleFor(x => x.FixSalary).NotEmpty().NotNull();
            RuleFor(x => x.Address).NotEmpty().NotNull();
            RuleFor(x => x.FixSalary).NotEmpty().NotNull();
           // RuleFor(x => x.Store).NotEmpty().NotNull();
        }
    }
}
