using Microsoft.EntityFrameworkCore;
using reforma_agraria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace reforma_agraria.Data
{
    public class ReformaAgrariaDbContext : DbContext
    {
        public ReformaAgrariaDbContext(DbContextOptions<ReformaAgrariaDbContext> options) : base(options)
        {

        }

        public DbSet<Region> Region { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Region>().ToTable("Region");
        }
    }
}
