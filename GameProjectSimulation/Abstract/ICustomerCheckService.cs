using GameProjectSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectSimulation.Abstract
{
    public interface ICustomerCheckService
    {
        bool checkIfRealPerson(Customer customer);
    }
}
