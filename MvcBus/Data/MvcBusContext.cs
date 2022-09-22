using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcBus.Models;

namespace MvcBus.Data
{
    public class MvcBusContext : DbContext
    {
        public MvcBusContext (DbContextOptions<MvcBusContext> options)
            : base(options)
        {
        }

        public DbSet<MvcBus.Models.Bus> Bus { get; set; }
    }
}
