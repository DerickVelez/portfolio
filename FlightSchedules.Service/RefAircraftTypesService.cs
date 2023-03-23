using FlightSchedules.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSchedules.Service
{
    public class RefAircraftTypesService
    {
        public List<RefAircraftTypes> RefServiceTypesList = new List<RefAircraftTypes>
        {
            new RefAircraftTypes
            {
               AircraftTypeCode = 5,
               AircraftTypeCapacity = 5455,
               AircraftTypeName = "TestAircraft",


            }
        };

        public bool IsAlreadyRegistered(int refAircraftType)
        {
            var refaircrafttype = RefServiceTypesList.Where(a => a.AircraftTypeCode == refAircraftType).FirstOrDefault();
            return refaircrafttype != null;
        }

        public List<RefAircraftTypes> GetRefAircraft()
        {
            return RefServiceTypesList;
        }

        public void Add(RefAircraftTypes refaircrafttype)
        {
            RefServiceTypesList.Add(refaircrafttype);
        }

        public void Delete(RefAircraftTypes refaircrafttypr)
        {
            var deletedrefaircrafttype = RefServiceTypesList.Where(a => a.AircraftTypeCode == refaircrafttypr.AircraftTypeCode).FirstOrDefault();
            RefServiceTypesList.Remove(deletedrefaircrafttype);
        }

        public void Update(RefAircraftTypes refaircrafttypr)
        {
            var updatedrefaircrafttype = RefServiceTypesList.Where(a => a.AircraftTypeCode == refaircrafttypr.AircraftTypeCode).FirstOrDefault();
            RefServiceTypesList.Remove(updatedrefaircrafttype);
            RefServiceTypesList.Add(refaircrafttypr);
        }


    }
}
