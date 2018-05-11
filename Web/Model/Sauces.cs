using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Model
{
    public class Sauces
    {
        public int saucesIDs { get; set; }
        public String saucesname { get; set; }

        public ICollection<CustomOrders> customOrders { get; set; }
    }
}
