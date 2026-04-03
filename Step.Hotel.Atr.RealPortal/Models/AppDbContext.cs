using Microsoft.EntityFrameworkCore;

namespace Step.Hotel.Atr.RealPortal.Models
{
    public class AppDbContext : DbContext {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            :base(options)
        {
            
        }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Event> Events { get; set; }
    }
}
