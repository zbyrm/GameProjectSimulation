using GameProjectSimulation.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectSimulation.Entities
{
    //if customer buy a product, he can buy second product with 50% discount
    public class OneBuyOneDiscount : ICampaign
    {
        public void calculateDiscount()
        {
            Console.WriteLine("One Buy One Discount calculated!");
        }

        public double getDiscountRate()
        {
            return 0.50;
        }
    }
}
