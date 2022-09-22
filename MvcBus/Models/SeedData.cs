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
                        Title = "Doubledecker bus",
                        Arrival = DateTime.Parse("2022-9-28"),
                        Seats = "80",
                        Price = 10.99M
                    },

                    new Bus
                    {
                        Title = "Trolleybus",
                        Arrival = DateTime.Parse("2022-10-31"),
                        Seats = "49",
                        Price = 1.99M
                    },

                    new Bus
                    {
                        Title = "Articulated Bus",
                        Arrival = DateTime.Parse("2022-10-18"),
                        Seats = "76",
                        Price = 1.99M
                    }

                );
                context.SaveChanges();
            }
        }
    }
}