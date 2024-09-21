using IydePersonal.API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Metadata;

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

            builder.Property(x => x.UserId)
               .IsRequired()
               .HasColumnName("UserId");

            builder.HasOne(e => e.User)
               .WithOne(e => e.Store)
               .HasForeignKey<Store>(e => e.UserId)
               .IsRequired();
        }
    }
}
