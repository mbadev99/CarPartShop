using Microsoft.EntityFrameworkCore;
using CarPartShop.Entity;

namespace CarPartShop.PersistenceEF
{
    public class EfCarPartContext : DbContext
    {
        public DbSet<CarBrand> CarBrands { get; set; }
        public DbSet<CarModel> CarModels { get; set; }
        public EfCarPartContext(DbContextOptions<EfCarPartContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //var assembly = typeof()
            base.OnModelCreating(modelBuilder);
        }
    }
}
