using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class MenuUpdateValidator:AbstractValidator<Menu>
    {
        public MenuUpdateValidator()
        {
            RuleFor(m => m.ID).NotEmpty();
            RuleFor(m => m.ID).GreaterThan(0);
            RuleFor(m => m.Title).NotEmpty();
            RuleFor(m => m.Title).MinimumLength(5);
        }
    }
}
