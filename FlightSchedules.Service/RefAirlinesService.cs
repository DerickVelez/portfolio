﻿using FlightSchedules.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSchedules.Service
{
    public class RefAirlinesService
    {
        public List<RefAirlines> refAirlinesServiceList = new List<RefAirlines>
        {
            new RefAirlines
            {
               Airlinecode = 4645,
               AirlineName=  "NAIA",
               AirlineCountry = "PH"

            }
        };

        public bool IsAlreadyRegistered(int airlinecode)
        {
            var Refairline = refAirlinesServiceList.Where(a => a.Airlinecode == airlinecode).FirstOrDefault();
            return Refairline != null;
        }

        public List<RefAirlines> GetRefAirlines()
        {
            return refAirlinesServiceList;
        }

        public void Add(RefAirlines refairlines)
        {
            refAirlinesServiceList.Add(refairlines);
        }

        public List<RefAirlines> Delete(RefAirlines refairlines)
        {
            var updatedRefAirlines = refAirlinesServiceList.Where(a => a.Airlinecode == refairlines.Airlinecode).FirstOrDefault();
            refAirlinesServiceList.Remove(updatedRefAirlines);
            return refAirlinesServiceList;
        }

        public List<RefAirlines> Update(RefAirlines refairlines)
        {
            Delete(refairlines);
            refAirlinesServiceList.Add(refairlines);
            return refAirlinesServiceList;
        }


    }
}
