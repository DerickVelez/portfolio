using FlightSchedules.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSchedules.Service
{
    public class LegsService
    {
        public List<Legs> LegsServiceList = new List<Legs>
        {
            new Legs
            {
                LegID = 145,
                LegDestinationAirportCode =54,
                FlightNumber = 321,
                LegOriginAiportCode = 453,
                LegSequence = 544,

            }
        };

        public bool IsAlreadyRegistered(int legID)
        {
            var legs = LegsServiceList.Where(a => a.LegID == legID).FirstOrDefault();
            return legs != null;
        }

        public List<Legs> GetLegs()
        {
            return LegsServiceList;
        }

        public void Add(Legs legs)
        {
            LegsServiceList.Add(legs);
        }

        public List<Legs> Delete(Legs legs)
        {
            var updatedLegs = LegsServiceList.Where(a => a.LegID == legs.LegID).FirstOrDefault();
            LegsServiceList.Remove(updatedLegs);
            return LegsServiceList;
        }

        public void Update(Legs legs)
        {
            Delete(legs);
            LegsServiceList.Add(legs);
        }

        
    }
}
