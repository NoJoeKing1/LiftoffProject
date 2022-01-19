using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NationalParkRecommendation.Models;

namespace NationalParkRecommendation.Data
{
    public class ParksDbContext : IdentityDbContext<IdentityUser>
    {

        /*public DbSet<User> Users { get; set; }*/
        public DbSet<Park> Parks { get; set; }
        public ParksDbContext(DbContextOptions<ParksDbContext> options)
            : base(options)
        {
        }

        /*protected override void OnModelCreating(ModelBuilder builder)
        {
            ModelBuilder.Entity<ParkTag>().HasKey(pt => new { pt.ParkId, TagId });
            base.OnModelCreating(builder);
        }*/
    }
}
