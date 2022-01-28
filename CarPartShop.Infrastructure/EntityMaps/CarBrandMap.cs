using CarPartShopApi.Domain.CarBrandAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPartShop.Infrastructure.EntityMaps
{
    public class CarBrandMap : IEntityTypeConfiguration<CarBrand>
    {
        public void Configure(EntityTypeBuilder<CarBrand> builder)
        {
            builder.ToTable("CarBrands");
            builder.HasKey(_ => _.Id);
            builder.Property(_ => _.Name).HasMaxLength(255).IsRequired();

            builder.HasMany(_ => _.Models)
                .WithOne(_ => _.Brand)
                .HasForeignKey(_ => _.BrandId)
                .OnDelete(DeleteBehavior.ClientNoAction);
        }
    }
}
