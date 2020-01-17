using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripTracker.BackService.Models
{
    public class Repository
    {
        private List<Trip> MyTrips = new List<Trip>
        {
            new Trip
            {
                Id=1,
                Name="MCP",
                StartDate = new DateTime(2020,01,01),
                EndDate = new DateTime(2020,02,02)
            },
            new Trip
            {
                Id=2,
                Name="MCP",
                StartDate = new DateTime(2020,01,01),
                EndDate = new DateTime(2020,02,02)
            },new Trip
            {
                Id=3,
                Name="MCP",
                StartDate = new DateTime(2020,01,01),
                EndDate = new DateTime(2020,02,02)
            }
        };
        public List<Trip> Get()
        { return MyTrips; }
        public Trip Get(int id)
        {
            return MyTrips.First(t => t.Id == id);
        }
        public void Add(Trip newTrip)
        {
            MyTrips.Add(newTrip);
        }
        public void Update(Trip triptoUpdate)
        {
            MyTrips.Remove(MyTrips.First(t => t.Id == triptoUpdate.Id));
        }
        public void Remove(int id)
        {
            MyTrips.Remove(MyTrips.First(t => t.Id == id));
        }
    }
}
