using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace Business.Abstract
{
    //iş katmanında kullanacağımız servis operasyonları
    public interface IProductService
    {
        List<Product> GetAll();
    }
}
