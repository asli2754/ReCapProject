using System;
using Gun5Odev4.Entities;
using InterfacesAbstractDemo.Abstract;
using InterfacesAbstractDemo.Concrete;

namespace Gun5Odev4
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(new Customer { DateOfBirth= new DateTime(1985,1,6),FirstName="Aslı",LastName="Efe",NationalityId="288614499852"});
        }
    }
}
