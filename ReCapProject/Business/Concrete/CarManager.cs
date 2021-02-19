using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        //Business katmanında DataAccess katmanını kullanabilmek için constructor injection uygulandı.
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        //İş kuralları eklendi
        public void Add(Car car)
        {
            if (car.Description.Length >= 2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
            }
            else
            {
                Console.WriteLine("Hata! Araba tanımınız en az 2 karakterden oluşmalıdır veya günlük fiyat 0'dan büyük olmalıdır.");
            }
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetByBrandId(int id)
        {
            return _carDal.GetByBrandId(id);
        }

        public List<Car> GetByColorId(int id)
        {
            return _carDal.GetByColorId(id);
        }



        public void Update(Car car)
        {
            if (car.Description.Length >= 2 && car.DailyPrice > 0)
            {
                _carDal.Update(car);
            }
            else
            {
                Console.WriteLine("Hata! Araba tanımınız en az 2 karakterden oluşmalıdır veya günlük fiyat 0'dan büyük olmalıdır.");
            }
        }
    }
}
