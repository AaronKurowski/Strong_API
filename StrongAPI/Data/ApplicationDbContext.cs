using StrongAPI.Configuration;
using StrongAPI.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace StrongAPI.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions options)
            :base(options)
        {

        }
        public DbSet<Gear> Gear { get; set; }
        public DbSet<ShowListing> ShowListings { get; set; }
        public DbSet<GearBag> GearBags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GearBag>().HasKey(GB => new { GB.UserId, GB.GearId });
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new RolesConfiguration());
        }

    }
}
