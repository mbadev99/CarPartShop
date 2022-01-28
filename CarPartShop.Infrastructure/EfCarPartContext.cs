using CarPartShopApi.Domain.CarBrandAgg;
using CarPartShopApi.Domain.CarModelAgg;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPartShop.Infrastructure
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
