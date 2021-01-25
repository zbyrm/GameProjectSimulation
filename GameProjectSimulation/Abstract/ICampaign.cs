using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectSimulation.Abstract
{
    public interface ICampaign
    {
        double getDiscountRate();
        void calculateDiscount();
    }
}
