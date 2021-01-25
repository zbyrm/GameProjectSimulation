using GameProjectSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectSimulation.Abstract
{
    interface ICart
    {
        void Add(Product product);
        void Buy(ICampaign campaign);

        void Delete(Product product);

        void List();
    }
}
