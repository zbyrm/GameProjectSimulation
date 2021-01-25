using GameProjectSimulation.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectSimulation.Entities
{
    public class Customer: IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateofBirth { get; set; }
        public string NationalityId { get; set; }
    }
}
