using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Model
{
    public class Adress
    {
        public int adressIDs { get; set; }
        public String street { get; set; }
        public int zipcode { get; set; }
        public String state { get; set; }

        public Customers Customers { get; set; }
    }
}
