using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingStore.Data.Entities
{
    public class Products
    {
        public int ProductID { get; set; }

        public string ProductDescription { get; set; }

        public string ProductName { get; set; }

        public int ProductPrice { get; set; }

        public int ProductTypeCode { get; set; }

        public string GameName { get; set; }

        public string DriveType { get; set; }

        public string AccessoryName { get; set; }

        public int OrderID { get; set; }

        public int PurchaseID { get; set; }
    }
}
