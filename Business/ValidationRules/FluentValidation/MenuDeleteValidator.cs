using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class MenuDeleteValidator:AbstractValidator<Menu>
    {
        public MenuDeleteValidator()
        {
            RuleFor(m => m.ID).GreaterThan(0);
        }
    }
}
