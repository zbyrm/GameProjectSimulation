using GameProjectSimulation.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectSimulation.Entities
{
    class EndOfYearCampaign : ICampaign
    {
        public void calculateDiscount()
        {
            Console.WriteLine("End Of Year Campain calculated!");
        }

        public double getDiscountRate()
        {
            return 0.20;  
        }
    }
}
