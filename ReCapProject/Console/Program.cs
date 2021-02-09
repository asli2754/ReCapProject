using System;
using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }

            Car car1 = new Car() { Description = "Opel", BrandID = 5, ColorID = 31, DailyPrice = 120000, ID = 4, ModelYear = new DateTime(2012) };
            carManager.Add(car1);
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.ModelYear + " Model " + car.Description + " : " + car.DailyPrice + "TL");
            }

            //Console.WriteLine("den"+carManager.GetById(5).Count);

            foreach (var car in carManager.GetById(5))
            {
                Console.WriteLine("ID=5 olan araç:" + car.ModelYear + " Model " + car.Description + " : " + car.DailyPrice + "TL");
            }


           
        }

        }
    }

