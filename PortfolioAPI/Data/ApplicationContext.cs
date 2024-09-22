using Microsoft.EntityFrameworkCore;
using PortfolioAPI.Entities;

namespace PortfolioAPI.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Experience> Experiences { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }
    }
}
