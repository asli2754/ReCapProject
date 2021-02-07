using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products; //global değişken olduğu için alt çizgi ile verdik.
        public InMemoryProductDal()//constactor
        {   //oracle, sql server, postgres, MongoDb'den geliyor gibi.
            _products = new List<Product>
            {
                new Product{ProductID=1,CategoryID=1,ProductName="Bardak",UnitPrice=15,UnitsInStock=15},
                new Product{ProductID=2,CategoryID=1,ProductName="Kamera",UnitPrice=500,UnitsInStock=3},
                new Product{ProductID=3,CategoryID=2,ProductName="Telefon",UnitPrice=1500,UnitsInStock=2},
                new Product{ProductID=4,CategoryID=2,ProductName="Klavye",UnitPrice=150,UnitsInStock=65},
                new Product{ProductID=5,CategoryID=2,ProductName="Fare",UnitPrice=85,UnitsInStock=1}
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //silinecek ürünü bulmalıyız.
            //LINQ - Language Integrated Query
            //Lambda p>=, buradaki p bizim takma adımız
           // Product productToDelete = null; //referansı yok, şimdilik null girdik hata vermesin diye.
           // foreach (var p in _products)
           // {
           //     if (product.ProductID == p.ProductID)
           //     {
           //        productToDelete = p; //silinecek elemen bu.
           //     }
          //  }

            //yukarıdaki kod yerine aşağıdaki linki kullanıcaz.
           Product productToDelete = _products.SingleOrDefault(p=>product.ProductID==product.ProductID); // for each yerine kullanıldı.

            _products.Remove(productToDelete); 
        }

        public List<Product> GetAll()
        {
            return _products;
        }


        public void Update(Product product)
        {
            //Gönderdiğim ürün ID'sine sahip olan listedeki ürünü bul.
            Product productToUpdate = _products.SingleOrDefault(p=> product.ProductID == product.ProductID);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryID = product.CategoryID;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;

        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            //where koşulu içindeki şarta uyan bütün elemanları yeni bir liste haline getirip onu döndürür.
           return _products.Where(p => p.CategoryID == categoryId).ToList();
        }

    }
}
