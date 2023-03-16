using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Data.Entitites
{
    public class OrderItems
    {
        public int ItemNumber { get; set; }

        public int ItemAgreedPrice { get; set; }

        public string ItemComment { get; set; }

        public DateTime OrderDate { get; set; }
    }
}
