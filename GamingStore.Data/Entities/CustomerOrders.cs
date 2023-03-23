using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingStore.Data.Entities
{
    public class CustomerOrders
    {
        public int OrderID { get; set; }

        public DateTime DateOfOrder { get; set; }

        public string OtherOrderDetails { get; set; }

    }
}
