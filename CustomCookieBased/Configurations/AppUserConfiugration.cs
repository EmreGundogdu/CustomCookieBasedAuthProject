using CustomCookieBased.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomCookieBased.Configurations
{
    public class AppUserConfiugration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.Property(x => x.Password).HasMaxLength(200).IsRequired();
            builder.Property(x => x.Username).HasMaxLength(250).IsRequired();
        }
    }
    public class AppRoleConfiugration : IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> builder)
        {
            builder.Property(x => x.Definition).HasMaxLength(200).IsRequired();
        }
    }
    public class AppUserRoleConfiugration : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            builder.HasKey(x => new { x.UserId, x.RoleId });
            builder.HasOne(x => x.AppRole).WithMany(x => x.AppUserRoles).HasForeignKey(x => x.RoleId);
            builder.HasOne(x => x.AppUser).WithMany(x => x.AppUserRoles).HasForeignKey(x => x.UserId);
        }
    }
}
