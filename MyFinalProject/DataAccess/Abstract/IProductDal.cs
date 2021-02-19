using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAcces;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetails();

    }
}
//code refactoring: kodun iyileştirilmesi