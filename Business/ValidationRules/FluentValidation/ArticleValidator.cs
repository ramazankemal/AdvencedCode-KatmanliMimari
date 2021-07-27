using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ArticleValidator:AbstractValidator<Article>
    {
        public ArticleValidator()
        {
            RuleFor(a => a.Title).NotEmpty();
            RuleFor(a => a.Title).MinimumLength(5);
            RuleFor(a => a.Content).NotEmpty();
            RuleFor(a => a.MenuId).NotEmpty();
            
        }
    }
}
