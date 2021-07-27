using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class MenuManager : IMenuService
    {
        IMenuDal _menuDal;

        public MenuManager()
        {
            _menuDal = new EfMenuDal();
        }

        public IResult Add(Menu menu)
        {
            ValidationTool.Validate(new MenuValidator(),menu);

             _menuDal.Add(menu);
            return new SuccessResult(Messages.MenuAdded);
        }

        public IResult Delete(Menu menu)
        {
            ValidationTool.Validate(new MenuDeleteValidator(), menu);

            _menuDal.Add(menu);
            return new SuccessResult(Messages.MenuDeleted);
        }

        public IDataResult<List<Menu>> GetAll()
        {
            return new SuccessDataResult<List<Menu>>(_menuDal.GetAll(), Messages.MenuListed);
        }

        public IDataResult<Menu> GetById(int id)
        {
            return new SuccessDataResult<Menu>(_menuDal.Get(m=>m.ID==id));
        }

        public IResult Update(Menu menu)
        {
            ValidationTool.Validate(new MenuUpdateValidator(), menu);

            _menuDal.Update(menu);
            return new SuccessResult(Messages.MenuUpdated);
        }
    }
}
