using CarPartShop.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarPartShop.PersistenceEF.EntityMaps
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
