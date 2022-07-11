using CqRsMediatr.Domain;
using Microsoft.EntityFrameworkCore;

namespace CqRsMediatr.Infraestructure.Persistence
{
    public class MyAppDbContext : DbContext
    {
        public MyAppDbContext(DbContextOptions<MyAppDbContext> options)
            :base(options)
          
        {

        }

        public DbSet<Product> Products => Set<Product>();
    }
}
