using IydePersonal.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IydePersonal.API.Data.Configurations
{
    //public class EmployeePunktConfiguration : IEntityTypeConfiguration<EmployeePunkt>
    //{
    //    //public void Configure(EntityTypeBuilder<EmployeePunkt> builder)
    //    //{
    //    //    builder.ToTable("EmployeePunkts");

    //    //    builder.HasKey(x => new { x.EmployeeId, x.PunktId });

    //    //    builder.HasKey(x => x.Id);

    //    //    builder.Property(x => x.Id)
    //    //     .HasColumnName("Id");

    //    //    builder.Property(x => x.CreateDate)
    //    //        .IsRequired()
    //    //        .HasColumnName("CreateDate");

    //    //    builder.Property(x => x.EmployeeId)
    //    //        .IsRequired()
    //    //        .HasColumnName("EmployeeId");

    //    //    builder.Property(x => x.PunktId)
    //    //       .IsRequired()
    //    //       .HasColumnName("PunktId");

    //    //    builder.HasData(new EmployeePunkt
    //    //    {
    //    //        Id=1,
    //    //        EmployeeId=1,
    //    //        PunktId=1,
    //    //        CreateDate=DateTime.Now,
    //    //    });
    //    //}
    //}
}
