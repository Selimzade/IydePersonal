using IydePersonal.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IydePersonal.API.Data.Configurations
{
    public class PunktConfiguration : IEntityTypeConfiguration<Punkt>
    {
        public void Configure(EntityTypeBuilder<Punkt> builder)
        {
            builder.ToTable("Punkts");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
             .HasColumnName("Id");

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(500)
                .HasColumnName("Name");

            builder.Property(x => x.Point)
               .IsRequired()
               .HasColumnName("Point");
        }
    }
}
