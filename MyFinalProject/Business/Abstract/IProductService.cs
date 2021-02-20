using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    //iş katmanında kullanacağımız servis operasyonları
    public interface IProductService
    {
        //List<Product> GetAll();
        IDataResult<List<Product>> GetAll();//hem işlem sonucu hem mesajıdöndürmek
        
        //List<Product> GetAllByCategoryId(int id);
        IDataResult<List<Product>> GetAllByCategoryId(int id);
       
        //List<Product> GetByUnitPrice(decimal min, decimal max);//fiyat aralığındakileri getirir.
        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);

        //List<ProductDetailDto> GetProductDetails();
        IDataResult<List<ProductDetailDto>> GetProductDetails();

        //Product GetById(int productId);
        IDataResult<Product> GetById(int productId);
       
        //void Add(Product product);
        IResult Add(Product product);

    }
}
