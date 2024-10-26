using IydePersonal.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IydePersonal.API.Data.Configurations
{
    public class EmployeeLogConfiguration : IEntityTypeConfiguration<EmployeeLog>
    {
        public void Configure(EntityTypeBuilder<EmployeeLog> builder)
        {
            builder.ToTable("EmployeeLogs");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .IsRequired()
               .HasColumnName("Id");

            builder.Property(x => x.CreateDate)
                .IsRequired()
               .HasColumnName("CreateDate");

            builder.Property(x => x.StoreId)
               .IsRequired()
               .HasColumnName("StoreId");

            builder.Property(x => x.EmployeeId)
             .IsRequired()
             .HasColumnName("EmployeeId");

            builder.HasOne(x => x.Store)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
