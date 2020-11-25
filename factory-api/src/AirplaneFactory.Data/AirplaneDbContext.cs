using Microsoft.EntityFrameworkCore;

namespace AirplaneFactory.Data
{
    public class AirplaneDbContext : DbContext
    {
        public AirplaneDbContext(DbContextOptions<AirplaneDbContext> options): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AirplaneDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
