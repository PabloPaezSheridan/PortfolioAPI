using Microsoft.EntityFrameworkCore;
using PortfolioAPI.Data.Entities;

namespace PortfolioAPI.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<User> Users { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }
    }
}
