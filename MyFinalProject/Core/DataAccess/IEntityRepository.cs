using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.Entities;

namespace Core.DataAcces
{
    //herkesistediği T'yi yazamasın diyesınırlamma yapalım.Generic constraint.
    //class:referans tip. Tüm classları ortak olarak IEntity yapmıştık.
    //IEntity: IEntity olabilir veya IEntity implemente eden bir nesne olabilir.
   //new():newlenebilir olmalı dedik. IEntity de newlenemediği için bunu da devre dışı bırakmış olduk.
    public interface IEntityRepository<T> where T:class, IEntity,new()
    {//generic repositery design petter
        List<T> GetAll(Expression<Func<T, bool>> filter=null); //filtre olmayadabilir.
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        //List<T> GetAllByCategory(int categoryId);//artık ihtiyaç kalmadı filtre ekldik yukarıda.

    }
}
