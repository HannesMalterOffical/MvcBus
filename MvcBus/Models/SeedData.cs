using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcBus.Data;
using System;
using System.Linq;

namespace MvcBus.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcBusContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcBusContext>>()))
            {
                // Look for any movies.
                if (context.Bus.Any())
                {
                    return;   // DB has been seeded
                }

                context.Bus.AddRange(
                    new Bus
                    {
                        Type = "Doubledecker bus",
                        Arrival = DateTime.Parse("2022-9-28"),
                        Seats = "80",
                        Speed = 40,
                        Price = 10.00M
                    },

                    new Bus
                    {
                        Type = "Trolleybus",
                        Arrival = DateTime.Parse("2022-10-31"),
                        Seats = "49",
                        Speed= 55,
                        Price = 1.00M
                    },

                    new Bus
                    {
                        Type = "Articulated Bus",
                        Arrival = DateTime.Parse("2022-10-18"),
                        Seats = "76",
                        Speed = 60,
                        Price = 1.00M
                    }

                );
                context.SaveChanges();
            }
        }
    }
}