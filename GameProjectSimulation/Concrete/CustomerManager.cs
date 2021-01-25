using GameProjectSimulation.Abstract;
using GameProjectSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectSimulation.Concrete
{
    class CustomerManager: BaseCustomerManager
    {
        private ICustomerCheckService _customerCheckService;

        public CustomerManager(ICustomerCheckService customerCheckService)
        {
            this._customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {
            //mernis dogrulaması yapılacak
            if (_customerCheckService.checkIfRealPerson(customer))
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
