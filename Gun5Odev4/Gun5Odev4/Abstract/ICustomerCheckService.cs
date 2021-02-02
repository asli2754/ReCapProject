using System;
using System.Collections.Generic;
using System.Text;
using Gun5Odev4.Entities;

namespace InterfacesAbstractDemo.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
