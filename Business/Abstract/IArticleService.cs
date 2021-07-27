
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IArticleService
    {
        IResult Add(Article article);
        IResult Update(Article article);
        IResult Delete(Article article);
        IDataResult<Article> GetById(int id);
        IDataResult<List<Article>> GetAll();
    }
}
