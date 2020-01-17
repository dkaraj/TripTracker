using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TripTracker.BackService.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace TripTracker.BackService.Data

{
    public class TripContext : DbContext
    {
        public TripContext(DbContextOptions<TripContext> options) :base(options)

        {


        }
        public TripContext() { }
        public DbSet<Trip> Trips { get; set; }


        public static void SeedData(IServiceProvider serviceProvider)
        {
            using (var serviceScope = serviceProvider
                 .GetRequiredService<IServiceScopeFactory>().CreateScope())

            {
                var context = serviceScope.ServiceProvider.GetService<TripContext>();
                context.Database.EnsureCreated();
                if (context.Trips.Any()) return;
                context.Trips.AddRange(new Trip[]
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

                });
                context.SaveChanges();
            }
        }

    }
}
