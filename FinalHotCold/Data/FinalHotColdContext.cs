using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using FinalHotCold.Models;

namespace FinalHotCold.Data
{
    public class FinalHotColdContext : DbContext
    {
        public FinalHotColdContext()
        {
        }

        public FinalHotColdContext (DbContextOptions<FinalHotColdContext> options)
            : base(options)
        {
        }

        public DbSet<FinalHotCold.Models.Category> Category { get; set; } = default!;

        public DbSet<FinalHotCold.Models.Product>? Product { get; set; }

        public DbSet<FinalHotCold.Models.Order>? Order { get; set; }
    }
}
