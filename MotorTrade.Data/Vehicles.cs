using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorTrade.Data
{
    public class Vehicles
    {
        public int VehicleID { get; set; }

        public int ModelTypeCode { get; set; }

        public string VehicleName { get; set; }

        public DateTime LaunchDate { get; set; }

        public string OtherDetails { get; set; }
    }
}
