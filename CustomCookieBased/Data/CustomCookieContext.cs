using CustomCookieBased.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomCookieBased.Data
{
    public class CustomCookieContext : DbContext
    {
        public CustomCookieContext(DbContextOptions<CustomCookieContext> options):base(options)
        {

        }
        public DbSet<AppUser> Users { get; set; }
        public DbSet<AppRole> Roles { get; set; }
        public DbSet<AppUserRole> UserRoles { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AppUserConfiugration());
            modelBuilder.ApplyConfiguration(new AppRoleConfiugration());
            modelBuilder.ApplyConfiguration(new AppUserRoleConfiugration());
        }
    }
}
