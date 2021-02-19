using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAcces;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface ICategoryDal:IEntityRepository<Category>
    {
       /* List<Category> GetAll();
        void Add(Category category);
        void Update(Category category);
        void Delete(Category category);
        List<Category> GetAllByCategory(int categoryId);*/


    }
}
