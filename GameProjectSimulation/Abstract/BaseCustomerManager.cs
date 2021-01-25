using GameProjectSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectSimulation.Abstract
{
    public abstract class BaseCustomerManager: ICustomerService
    {        
        //virtual anahtar kelimesi kullanılınca imlemente edilen classtan
        //bu metot ezilebilir
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Save to db : " + customer.FirstName);
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("Update : " + customer.FirstName);
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Deleted : " + customer.FirstName);
        }

    }
}
