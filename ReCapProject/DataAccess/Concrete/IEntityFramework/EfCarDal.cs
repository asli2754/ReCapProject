using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.IEntityFramework
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            //IDisposable pattern implementation of c#
            using (NorthwindContext context = new NorthwindContext()) // Belleği hızlıca tamizlemek için using kullanıyoruz.
            {                                                       //Using kullanıldıktan sonra garbage collectoraı çağırır ve çöpe girer.
                var addedEntity = context.Entry(entity); // Referansla kontrol ediyoruz.
                addedEntity.State = EntityState.Added; // Durumunu ekle yapıyoruz
                context.SaveChanges(); // İşlemi tamamlıyoruz.
            }
        }

        public void Delete(Car entity)
        {

            using (NorthwindContext context = new NorthwindContext())
            {
                var addedEntity = context.Entry(entity); // Referansla kontrol ediyoruz.
                addedEntity.State = EntityState.Deleted; // Durumunu silme yapıyoruz
                context.SaveChanges(); // İşlemi tamamlıyoruz.
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Set<Car>().SingleOrDefault(filter);
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return filter == null ? context.Set<Car>().ToList() // ? ile nullmı sorgusu yapıyoruz, öyleyse List şeklinde hepsini veriyoruz.
                    : context.Set<Car>().Where(filter).ToList();   // : ile null değilse where ile getirilen koşula göre listeyi ver demek.
            }       // System.Linq eklemyi unutmayalım. 
        }

        public List<Car> GetByBrandId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetByColorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Car entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var addedEntity = context.Entry(entity); // Referansla kontrol ediyoruz.
                addedEntity.State = EntityState.Modified; // Durumunu modifiye etmek yapıyoruz, yani güncelliyor :)
                context.SaveChanges(); // İşlemi tamamlıyoruz.
            }
        }
    }
}
