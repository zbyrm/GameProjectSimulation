using GameProjectSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectSimulation.Abstract
{
    public interface IProductService
    {
        public void Save(Product product);
        void Update(Product product);
        void Delete(Product product);
    }
}
