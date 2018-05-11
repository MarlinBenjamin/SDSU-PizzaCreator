using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Model
{
    public class Customers
    {
        public String Lastname { get; set; }
        public String FirstName { get; set; }
        public String Middlename { get; set; }
        public DateTime Timeorders { get; set; }
        public int addressIDs { get; set; }

        public ICollection<CustomOrders> customOrders { get; set; }
        public Address Adress { get; set; }
    }
}
