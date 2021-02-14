using Entitites.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entitites.Concrete
{   // Customer class is an Entity meaning that a table in Northwind db.
    public class Customer:IEntity
    {
        public string CustomerId { get; set; }

        public string ContactName { get; set; }

        public string CompanyName { get; set; }

        public string City { get; set; }
    }
}
