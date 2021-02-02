using System;
using System.Collections.Generic;
using System.Text;
using Gun5Odev4.Entities;
using InterfacesAbstractDemo.Abstract;

namespace InterfacesAbstractDemo.Concrete
{
    public class StarbucksCustomerManager:BaseCustomerManager


    {
        private ICustomerCheckService _customerCheckService;

        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {
            //mernis uygulaması ekle

            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
            
            
            
        }

  

    }


}
