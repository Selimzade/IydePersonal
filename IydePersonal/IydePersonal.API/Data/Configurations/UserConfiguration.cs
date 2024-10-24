using IydePersonal.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IydePersonal.API.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
             .HasColumnName("Id");

            builder.Property(x => x.UserName)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("Username");

            builder.Property(x => x.Password)
               .IsRequired()
               .HasMaxLength(100)
               .HasColumnName("Password");

            builder.HasData( new User
                {
                    Id = 1,
                    UserName="Azadliq",
                    Password="123456"
                });
        }
    }
}
