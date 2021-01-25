using GameProjectSimulation.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectSimulation.Entities
{
    class HolidayCampaign : ICampaign
    {
        public void calculateDiscount()
        {
            Console.WriteLine("Holiday  Campaign calculated!");
        }

        public double getDiscountRate()
        {
            return 0.30;
        }
    }
}
