using IydePersonal.Domain.Entities.Edentity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IydePersonal.Infrastructure.Data.Configurations.IdentityMap
{
    public class UserMap : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            // Primary key
            builder.HasKey(u => u.Id);

            // Indexes for "normalized" username and email, to allow efficient lookups
            builder.HasIndex(u => u.NormalizedUserName).HasName("UserNameIndex").IsUnique();
            builder.HasIndex(u => u.NormalizedEmail).HasName("EmailIndex");

            // Maps to the AspNetUsers table
            builder.ToTable("AspNetUsers");

            // A concurrency token for use with the optimistic concurrency checking
            builder.Property(u => u.ConcurrencyStamp).IsConcurrencyToken();

            // Limit the size of columns to use efficient database types
            builder.Property(u => u.UserName).HasMaxLength(256);
            builder.Property(u => u.NormalizedUserName).HasMaxLength(256);
            builder.Property(u => u.Email).HasMaxLength(256);
            builder.Property(u => u.NormalizedEmail).HasMaxLength(256);

            // The relationships between User and other entity types
            // Note that these relationships are configured with no navigation properties

            // Each User can have many UserClaims
            builder.HasMany<AppUserClaim>().WithOne().HasForeignKey(uc => uc.UserId).IsRequired();

            // Each User can have many UserLogins
            builder.HasMany<AppUserLogin>().WithOne().HasForeignKey(ul => ul.UserId).IsRequired();

            // Each User can have many UserTokens
            builder.HasMany<AppUserToken>().WithOne().HasForeignKey(ut => ut.UserId).IsRequired();

            // Each User can have many entries in the UserRole join table
            builder.HasMany<AppUserRole>().WithOne().HasForeignKey(ur => ur.UserId).IsRequired();

            var superadmin = new AppUser
            {
                Id = 1,
                UserName = "Ehmed Mustafa",
                NormalizedUserName = "EHMED MUSTAFA",
                Email = "Prince.1987@mail.ru",
                NormalizedEmail = "PRINCE.1987@MAIL.RU",
                PhoneNumber = "+994502330644",
                FisrtName = "Ehmed",
                LastName = "Mustafa",
                PhoneNumberConfirmed = false,
                EmailConfirmed = false,
                SecurityStamp = 1.ToString(),
            };
            superadmin.PasswordHash = CreateHashPassWord(superadmin, "123456");


            var admin = new AppUser
            {
                Id = 2,
                UserName = "Omer Mustafa",
                NormalizedUserName = "OMER MUSTAFA",
                Email = "Prince.1987@mail.ru",
                NormalizedEmail = "PRINCE.1987@MAIL.RU",
                PhoneNumber = "+994502330644",
                FisrtName = "Omer",
                LastName = "Mustafa",
                PhoneNumberConfirmed = false,
                EmailConfirmed = false,
                SecurityStamp = 2.ToString(),
            };
            admin.PasswordHash = CreateHashPassWord(admin, "123456");

            var user = new AppUser
            {
                Id = 3,
                UserName = "Axmed Mustafa",
                NormalizedUserName = "AXMED MUSTAFA",
                Email = "Prince.1987@mail.ru",
                NormalizedEmail = "PRINCE.1987@MAIL.RU",
                PhoneNumber = "+994502330644",
                FisrtName = "Axmed",
                LastName = "Mustafa",
                PhoneNumberConfirmed = false,
                EmailConfirmed = false,
                SecurityStamp = 3.ToString(),
            };
            user.PasswordHash = CreateHashPassWord(user, "123456");

            builder.HasData(superadmin,admin,user);
        }


         
        private string CreateHashPassWord(AppUser user,string password)
        {
            var passwordHasher = new PasswordHasher<AppUser>();
            return passwordHasher.HashPassword(user, password);
        }
    }
}
