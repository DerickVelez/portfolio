using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingStore.Data
{
    public class CustomerPurchase
    {
        public int PurchaseID { get; set; }

        public DateTime DateOfPurchase { get; set; }

        public string OtherPurchaseDetails { get; set; }
    }
}
