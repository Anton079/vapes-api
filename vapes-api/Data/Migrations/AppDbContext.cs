using Microsoft.EntityFrameworkCore;
using vapes_api.Vapes.Models;

namespace vapes_api.Data.Migrations
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public virtual DbSet<Vape> Vapes { get; set; }
    }
}
