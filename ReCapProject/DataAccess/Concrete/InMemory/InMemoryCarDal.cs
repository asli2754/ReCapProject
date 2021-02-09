using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> 
            { 
               new Car{ID=1, BrandID=1, ColorID=23, DailyPrice=150000, Description="Skoda", ModelYear= new DateTime(2015)},
               new Car{ID=2, BrandID=1, ColorID=24, DailyPrice=190000, Description="Audi", ModelYear= new DateTime(2012)},
               new Car{ID=3, BrandID=3, ColorID=32, DailyPrice=250000, Description="Mercedes", ModelYear= new DateTime(2021)}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.BrandID == car.BrandID);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

     

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.BrandID == id).ToList();
        }

        public List<Car> GetByID(int brandID)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.BrandID == car.BrandID);
            carToUpdate.BrandID = car.BrandID;
            carToUpdate.ColorID = car.ColorID;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ID = car.ID;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
