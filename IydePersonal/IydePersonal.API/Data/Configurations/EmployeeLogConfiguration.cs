using IydePersonal.API.Entities;
using IydePersonal.Core.Entities;
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

            builder.HasOne<Store>()
               .WithMany()
               .HasForeignKey(x => x.StoreId)
               .OnDelete(DeleteBehavior.NoAction);

            builder.Property(x => x.EmployeeId)
             .IsRequired()
             .HasColumnName("EmployeeId");

            builder.HasOne<Employee>()
              .WithMany()
              .HasForeignKey(x => x.EmployeeId)
              .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
