using IydePersonal.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IydePersonal.Infrastructure.Data.Configurations
{
    public class DeleteDateConfiguration : IEntityTypeConfiguration<DeleteDate>
    {
        public void Configure(EntityTypeBuilder<DeleteDate> builder)
        {
            builder.ToTable("DeleteDates");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
               .HasColumnName("Id");

            builder.Property(x => x.Date)
                .IsRequired()
                .HasColumnName("date");
        }
    }
}
