using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IMenuService
    {
        IResult Add(Menu menu);
        IResult Update(Menu menu);
        IResult Delete(Menu menu);
        IDataResult<Menu> GetById(int id);
        IDataResult<List<Menu>> GetAll();
    }
}
