using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Data.Entitites
{
    public class Order
    {
        public DateOnly OrderDate { get; set; }
        
        public string OrderValue { get; set; }

        public int CustomerID { get; set; }
    }
}



+