using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ParkRec.Models;

namespace ParkRec.Data
{
    public class ParksDbContext : IdentityDbContext<IdentityUser>
    {

        public DbSet<Park> Parks { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<ParkTag> ParkTags { get; set; }
        public DbSet<UserPark> UserParks { get; set; }

        public ParksDbContext(DbContextOptions<ParksDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ParkTag>().HasKey(pt => new { pt.ParkId, pt.TagId });
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserPark>().HasKey(up => new { up.UserId, up.ParkId });
            base.OnModelCreating(modelBuilder);
        }
    }
}
