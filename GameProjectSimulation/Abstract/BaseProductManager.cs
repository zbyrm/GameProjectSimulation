using GameProjectSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectSimulation.Abstract
{
    public abstract class BaseProductManager : IProductService
    {
        public void Delete(Product product)
        {
            Console.WriteLine("Deleted product: " + product.GameName );
        }

        public void Save(Product product)
        {
            Console.WriteLine("Save product: " + product.GameName);
        }

        public void Update(Product product)
        {
            Console.WriteLine("Updated product: " + product.GameName);
        }
    }
}
