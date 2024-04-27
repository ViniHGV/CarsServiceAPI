using CarServiceAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarServiceAPI.Infra.DataBase
{
    public class AppDbContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite($"Data Source=CarsDb");
    }
}