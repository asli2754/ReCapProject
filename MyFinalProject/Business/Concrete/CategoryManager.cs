using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            //iş kodları
            return _categoryDal.GetAll();
        }

        //Select * from Categories where CategoryID = 3
        public Category GetById(int categoryId)
        {
            return _categoryDal.Get(c => c.CategoryID == categoryId);
           
        }

        public IEnumerable<object> GetByID(int v)
        {
            throw new NotImplementedException();
        }
    }
}
