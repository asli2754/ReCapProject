using System;
using System.Collections.Generic;
using System.Text;
using Gun5Odev4.Entities;
using InterfacesAbstractDemo.Abstract;

namespace InterfacesAbstractDemo.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;

        }

     
    }
}
