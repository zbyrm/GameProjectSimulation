using GameProjectSimulation.Abstract;
using GameProjectSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectSimulation.Concrete
{
    class CustomerCheckManager : ICustomerCheckService
    {
        public bool checkIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
