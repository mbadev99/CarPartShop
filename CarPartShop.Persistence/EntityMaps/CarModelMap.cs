using CarPartShop.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarPartShop.PersistenceEF.EntityMaps
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
