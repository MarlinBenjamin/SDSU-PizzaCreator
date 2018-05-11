using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Model
{
    public enum Delivery
    {
        pickup, attable, delivertohome
    }

    public class CustomOrders
    {
        public int receipIDs { get; set; }
        public int saucesIDs { get; set; }
        public int shapeIDs { get; set; }
        public int toppingIDs { get; set; }
        public Delivery? Delivery { get; set; }

        public Sauces Sauces { get; set; }
        public Shape Shape { get; set; }
        public Topping Topping { get; set; }
        public Customers Customers { get; set; }
    }
}
