using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ArticleDeleteValidator:AbstractValidator<Article>
    {
        public ArticleDeleteValidator()
        {
            RuleFor(a => a.ID).NotEmpty();
            RuleFor(a => a.ID).GreaterThan(0);
        }
    }
}
