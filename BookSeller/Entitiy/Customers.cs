using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSeller.Entitiy
{
    public class Customers
    {
        public int CustomerId { get; set; }
        public int CustomerCode { get; set; }

        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public int CustomerPhone { get; set; }
        public  int  CustomerEmail { get; set; }

    }
}
