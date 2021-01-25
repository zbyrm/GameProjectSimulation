using GameProjectSimulation.Abstract;
using GameProjectSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectSimulation.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool checkIfRealPerson(Customer customer)
        {
            MernisServiceReference.KPSPublicSoapClient client = new MernisServiceReference.KPSPublicSoapClient();
             
           return client.TCKimlikNoDogrula(Convert.ToInt64(customer.NationalityId), customer.FirstName.ToUpper()
            , customer.LastName.ToUpper(), customer.DateofBirth.Year);

            
        }
    }
}
