using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Model
{
    public class Topping
    {
        public String toppingname { get; set; }
        public int toppingIDs { get; set; }

        public ICollection<CustomOrders> customOrders { get; set; }
    }
}
