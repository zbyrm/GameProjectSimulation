using GameProjectSimulation.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectSimulation.Entities
{
    public class Game:IProduct 
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }       

    }
}
