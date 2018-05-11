using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Model
{
    public class Shape
    {
        public int shapeIDs { get; set; }
        public String shapenames { get; set; }

        public ICollection<CustomOrders> customOrders { get; set; }

    }
}
