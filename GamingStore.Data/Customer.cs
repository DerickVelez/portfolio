using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingStore.Data
{
    public class Customer
    {
        public int CustomerID { get; set; }

        public int CustomerCode { get; set; }

        public string CustomerName { get; set; }

        public string CustomerAddress { get; set; }

        public string CustomerOtherDetails { get; set; }

        public int PurchaseID { get; set; }

        public int OrderID { get; set; }
    }
}
