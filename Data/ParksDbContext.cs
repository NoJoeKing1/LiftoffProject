using Microsoft.EntityFrameworkCore;
using NationalParkRecommendation.Models;

namespace NationalParkRecommendation.Data
{
    public class ParksDbContext : DbContext
    {

        public DbSet<User> Users { get; set; }
        public DbSet<Park> Parks { get; set; }
        public ParksDbContext(DbContextOptions<ParksDbContext> options)
            : base(options)
        {
        }
    }
}
