using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ArticleManager : IArticleService
    {
        IArticleDal _articleDal;

        public ArticleManager()
        {
            _articleDal = new EfArticleDal();
        }

        public IResult Add(Article article)
        {
            ValidationTool.Validate(new ArticleValidator(),article);

            _articleDal.Add(article);
            return new SuccessResult(Messages.ArticleAdded);
        }

        public IResult Delete(Article article)
        {
            ValidationTool.Validate(new ArticleDeleteValidator(), article);

            _articleDal.Delete(article);
            return new SuccessResult(Messages.ArticleDeleted);
        }

        public IDataResult<List<Article>> GetAll()
        {
            return new SuccessDataResult<List<Article>>(_articleDal.GetAll(), Messages.ArticleListed);
        }

        public IDataResult<Article> GetById(int id)
        {
            return new SuccessDataResult<Article>(_articleDal.Get(a => a.ID == id));
        }

        public IResult Update(Article article)
        {
            ValidationTool.Validate(new ArticleUpdateValidator(),article);

            _articleDal.Update(article);
            return new SuccessResult(Messages.ArticleUpdated);
        }
    }
}
