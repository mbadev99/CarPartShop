using CarPartShopApi.Domain.CarBrandAgg;
using CarPartShopApi.Domain.CarModelAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPartShop.Infrastructure.EntityMaps
{
    public class CarModelMap : IEntityTypeConfiguration<CarModel>
    {
        public void Configure(EntityTypeBuilder<CarModel> builder)
        {
            builder.ToTable("CarModels");
            builder.HasKey(_ => _.Id);
            builder.Property(_ => _.Name).HasMaxLength(255).IsRequired();
            builder.Property(_ => _.BrandId).IsRequired();

            builder.HasOne(_ => _.Brand)
                .WithMany(_ => _.Models)
                .HasForeignKey(_ => _.BrandId)
                .OnDelete(DeleteBehavior.ClientNoAction);
        }
    }
}
