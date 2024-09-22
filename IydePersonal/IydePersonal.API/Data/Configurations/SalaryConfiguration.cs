using IydePersonal.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IydePersonal.API.Data.Configurations
{
    public class SalaryConfiguration : IEntityTypeConfiguration<Salary>
    {
        public void Configure(EntityTypeBuilder<Salary> builder)
        {
            builder.ToTable("Salaries");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
               .HasColumnName("Id");

            builder.Property(x => x.FixSalary)
               .IsRequired()
               .HasColumnName("FixSalary");

            builder.Property(x => x.Payment)
               .IsRequired()
               .HasColumnName("Payment");

            builder.Property(x => x.Sales)
               .IsRequired()
               .HasPrecision(18, 2)
               .HasColumnName("Sales");

            builder.Property(x => x.TotalCheck)
               .IsRequired()
               .HasPrecision(18, 2)
               .HasColumnName("TotalCheck");

            builder.Property(x => x.Award)
               .IsRequired()
               .HasColumnName("Award");

            builder.Property(x => x.Penalty)
               .IsRequired()
               .HasColumnName("Penalty");

            builder.Property(x => x.Countingdown)
               .IsRequired()
               .HasColumnName("Countingdown");

            builder.Property(x => x.AdditionalBonus)
               .IsRequired()
               .HasColumnName("AdditionalBonus");

            builder.Property(x => x.Conclusion)
               .IsRequired()
               .HasColumnName("Conclusion");

            builder.Property(x => x.CreateDate)
               .IsRequired()
               .HasColumnName("CreateDate");

            builder.Property(x => x.EmployeeId)
              .IsRequired()
              .HasColumnName("EmployeeId");
        }
    }
}
