using GameProjectSimulation.Abstract;
using GameProjectSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectSimulation.Concrete
{
    class CartManager : ICart
    {
        private Customer _customer;
        private List<Product> products;
        public CartManager(Customer customer)
        {
            this._customer = customer;
            products = new List<Product>();
        }
        public void Add(Product product)
        {
            products.Add(product);
            Console.WriteLine(product.GameName +  "  Added!");
        }

        public void Buy(ICampaign campaign)
        {
            if(products.Count==0)
            {
                Console.WriteLine("You must Add product to cart ");
                return; 
            }

            if(campaign!=null)
              campaign.calculateDiscount();

            Console.WriteLine(_customer.FirstName + "  " + _customer.LastName +
                " has bought " + products.Count + " products" ); ;
        }

        public void Delete(Product product)
        {
            products.Remove(product);
        }

        public void List()
        {
            foreach (Product product in products)
            {
                Console.WriteLine(product.GameName );
            }
        }
    }
}
