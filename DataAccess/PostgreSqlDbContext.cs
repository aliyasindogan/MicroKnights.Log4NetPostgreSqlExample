using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class PostgreSqlDbContext : DbContext
    {
        public PostgreSqlDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string PostgreSqlDbContext = "Server=localhost;Port=5432;Database=log4netDb;User Id=postgres;Pooling=true;Password=1212";
            optionsBuilder.UseNpgsql(PostgreSqlDbContext);
        }

        public virtual DbSet<log> log { get; set; }
    }
}