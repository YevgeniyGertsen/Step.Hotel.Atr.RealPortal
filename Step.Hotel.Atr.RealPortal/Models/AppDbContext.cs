using Microsoft.EntityFrameworkCore;

namespace Step.Hotel.Atr.RealPortal.Models
{
    public class AppDbContext : DbContext {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            :base(options)
        {
            
        }

        public DbSet<Team> Teams { get; set; }
    }
}
