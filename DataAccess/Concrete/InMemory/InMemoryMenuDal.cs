using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryMenuDal : IMenuDal
    {
        List<Menu> _menus;

        public InMemoryMenuDal()
        {
            _menus = new List<Menu>
            {
                new Menu{ID=1,Title="Katmanlı Mimari",Description="Test"},
                new Menu{ID=2,Title="Autofac",Description="Test"},
                new Menu{ID=3,Title="OOP",Description="Test"}
            };
        }


        public void Add(Menu entity)
        {
            _menus.Add(entity);
        }

        public void Delete(Menu entity)
        {
            Menu menuToDelete = null;
            menuToDelete = _menus.SingleOrDefault(m => m.ID == entity.ID);
            _menus.Remove(menuToDelete);
        }

        public void Update(Menu entity)
        {
            Menu menuToUpdate = _menus.SingleOrDefault(m => m.ID == entity.ID);
            menuToUpdate.Title = entity.Title;
            menuToUpdate.Description = entity.Description;
        }

        public List<Menu> GetAll()
        {
            return _menus;
        }

        public Menu GetById(int id)
        {
            return _menus.SingleOrDefault(m => m.ID == id);
        }

        public Menu Get(Expression<Func<Menu, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Menu> GetAll(Expression<Func<Menu, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

       
    }
}
