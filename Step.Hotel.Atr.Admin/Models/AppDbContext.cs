using Microsoft.EntityFrameworkCore;

namespace Step.Hotel.Atr.Admin.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            :base(options)
        {
            
        }
    }
}
