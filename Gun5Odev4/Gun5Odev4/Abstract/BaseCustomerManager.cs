using System;
using System.Collections.Generic;
using System.Text;
using Gun5Odev4.Entities;

namespace InterfacesAbstractDemo.Abstract
{ //abstract sınıfın içerisinde içi dolu void yapabiliriz.
    public abstract class BaseCustomerManager : ICustomerCheckService
    {
   
        public virtual void Save(Customer customer) // virtual dersek ezebiliriz demek.
        {
            Console.WriteLine("Saved to db : " + customer.FirstName);
        }
    }
}
