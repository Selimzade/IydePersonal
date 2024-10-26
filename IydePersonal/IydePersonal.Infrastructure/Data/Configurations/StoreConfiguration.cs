using IydePersonal.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IydePersonal.API.Data.Configurations
{
    public class StoreConfiguration : IEntityTypeConfiguration<Store>
    {
        public void Configure(EntityTypeBuilder<Store> builder)
        {
            builder.ToTable("Stores");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
               .HasColumnName("Id");

            builder.Property(x => x.Name)
               .IsRequired()
               .HasMaxLength(20)
               .HasColumnName("Name");

            builder.HasData(new Store
            {
                Id = 1,
                Name="Azadliq"
            });
        }
    }
}
