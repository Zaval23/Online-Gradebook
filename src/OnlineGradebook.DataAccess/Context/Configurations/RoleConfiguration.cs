using Microsoft.EntityFrameworkCore;
using OnlineGradebook.DataAccess.Entities;

namespace OnlineGradebook.DataAccess.Context.Configurations;

public static class RoleConfiguration
{
    public static void ConfigureRoleEntity(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<RoleEntity>().HasKey(x => x.Id);
        modelBuilder.Entity<RoleEntity>().HasIndex(x =>x.ExternalId).IsUnique();
        
        modelBuilder.Entity<RoleEntity>().Property(x => x.RoleName).IsRequired().HasMaxLength(50);
        modelBuilder.Entity<RoleEntity>().HasIndex(x => x.RoleName).IsUnique();
        
        modelBuilder.Entity<RoleEntity>().Property(x => x.Description).HasMaxLength(255);
    }
}