using GameProjectSimulation.Abstract;
using GameProjectSimulation.Concrete;
using GameProjectSimulation.Entities;
using System;

namespace GameProjectSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new CustomerManager(new CustomerCheckManager());

            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Ahmet",
                LastName = "Gundogan",
                DateofBirth = new DateTime(2000, 1, 1),
                NationalityId = "33333"
            };

            customerManager.Save(customer);


            Product game1 = new Product();
            game1.Id = 1;
            game1.GameName = "First Game";
            game1.Price = 10;

            Product game2 = new Product();
            game2.Id = 2;
            game2.GameName = "Second Game";
            game2.Price = 20;

            CartManager cartManager = new CartManager(customer);
            cartManager.Add(game1);
            cartManager.Add(game2);

            ICampaign campaign = new EndOfYearCampaign();
                                    // EndOfYearCampaign(); 
                                    //HolidayCampain();
                                    //EndOfSeriesDiscount();

            cartManager.Buy(campaign);

            
        }
    }
}
