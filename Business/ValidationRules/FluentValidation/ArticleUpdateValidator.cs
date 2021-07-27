using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ArticleUpdateValidator:AbstractValidator<Article>
    {
        public ArticleUpdateValidator()
        {
            RuleFor(a => a.ID).NotEmpty();
            RuleFor(a => a.ID).GreaterThan(0);
            RuleFor(a => a.Title).NotEmpty();
            RuleFor(a => a.Title).MinimumLength(5);
            RuleFor(a => a.Content).NotEmpty();
            RuleFor(a => a.MenuId).NotEmpty();
            RuleFor(a => a.MenuId).GreaterThan(0);
            
        }
    }
}
