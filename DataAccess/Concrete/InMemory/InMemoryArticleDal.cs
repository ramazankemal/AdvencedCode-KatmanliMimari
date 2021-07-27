using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryArticleDal : IArticleDal
    {
        List<Article> _articles;

        public InMemoryArticleDal()
        {
            _articles = new List<Article>
            {
                new Article{ID=1,MenuId=1,Title="Clean Code",Content="içerik",PublicationDate=DateTime.Now,RevisedDate=DateTime.Now},
                new Article{ID=2,MenuId=1,Title="Katmanlar",Content="İçerik",PublicationDate=DateTime.Now,RevisedDate=DateTime.Now},
                new Article{ID=3,MenuId=2,Title="Autofac kullanmak",Content="İçerik",PublicationDate=DateTime.Now,RevisedDate=DateTime.Now}
            };
        }


        public void Add(Article entity)
        {
            _articles.Add(entity);
        }

        public void Delete(Article entity)
        {
            Article articleToDelete = null; 
            articleToDelete = _articles.SingleOrDefault(a => a.ID == entity.ID);
            _articles.Remove(articleToDelete);

        }
        public void Update(Article entity)
        {
            Article articleToUpdate = null;
            articleToUpdate = _articles.SingleOrDefault(a => a.ID == entity.ID);
            articleToUpdate.MenuId = entity.MenuId;
            articleToUpdate.Title = entity.Title;
            articleToUpdate.Content = entity.Content;
            articleToUpdate.RevisedDate = DateTime.Now;
        }

        public Article GetById(int id)
        {
            return _articles.SingleOrDefault(a => a.ID == id);
        }

        public List<Article> GetAll()
        {
            return _articles;
        }

        public Article Get(Expression<Func<Article, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Article> GetAll(Expression<Func<Article, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

       
    }
}
