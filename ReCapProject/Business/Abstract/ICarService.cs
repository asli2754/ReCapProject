using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICarService
    {
        void Add(Car car);
        void Update(Car car);
        List<Car> GetAll();
        List<Car> GetByBrandId(int ID);
        List<Car> GetByColorId(int ID);
        

    }
}
