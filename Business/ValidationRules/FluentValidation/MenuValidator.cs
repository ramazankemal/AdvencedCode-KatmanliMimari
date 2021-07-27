using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class MenuValidator : AbstractValidator<Menu>
    {
        public MenuValidator()
        {
            RuleFor(m => m.Title).NotEmpty();
            RuleFor(m => m.Title).MinimumLength(5);
            //RuleFor(m => m.Title).Must(StartWithBigCharacter);
        }

        
    }
}
