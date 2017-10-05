using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using reforma_agraria.Models;
using Microsoft.AspNetCore.Identity;

namespace reforma_agraria.Data
{
    public class UserDataContext : IdentityDbContext<IdentityUser>
    {
        public UserDataContext(DbContextOptions<UserDataContext> options) : base(options)
        {
            //Database.EnsureCreated();
        }

        public DbSet<Credentials> Credentials { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Credentials>().ToTable("Credentials");
        }
    }
}
