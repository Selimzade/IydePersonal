using IydePersonal.Domain.Entities.Edentity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IydePersonal.Infrastructure.Data.Configurations.IdentityMap
{
    internal class UserRolemap : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {

            // Primary key
            builder.HasKey(r => new { r.UserId, r.RoleId });

            // Maps to the AspNetUserRoles table
            builder.ToTable("AspNetUserRoles");

            builder.HasData(new AppUserRole
            {
                UserId = 1,
                RoleId = 1,
            },
            new AppUserRole
            {
                UserId = 2,
                RoleId = 2,
            },

            new AppUserRole
            {
                UserId = 3,
                RoleId = 3,
            });

        }
    }
}
