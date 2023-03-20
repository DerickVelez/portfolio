using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorTrade.Data
{
    public class Sales
    {
        public int SaleID { get; set; }

        public int CustomerID { get; set; }

        public int VehicleID { get; set; }

        public  DateTime SaleDate { get; set; }

        public string OtherDetails { get; set; }
    }
}
