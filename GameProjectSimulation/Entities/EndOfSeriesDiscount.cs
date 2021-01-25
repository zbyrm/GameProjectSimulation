using GameProjectSimulation.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectSimulation.Entities
{
    class EndOfSeriesDiscount : ICampaign
    {
        public void calculateDiscount()
        {
            Console.WriteLine("End Of Series Discount calculated!");
        }

        public double getDiscountRate()
        {
            return 0.60; //%60
        }
    }
}
