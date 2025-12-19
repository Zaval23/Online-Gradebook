using Microsoft.EntityFrameworkCore;
using SalonBeauty.DataAccess.Entities;

namespace SalonBeauty.DataAccess.Context.Configurations;

public static class RoleConfiguration
{
    public static void ConfigureRoleEntity(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<RoleEntity>().HasKey(x => x.Id);
        modelBuilder.Entity<RoleEntity>().HasIndex(x =>x.ExternalId).IsUnique();
        
        modelBuilder.Entity<RoleEntity>().Property(x => x.Role).HasConversion<string>().HasMaxLength(50).IsRequired();

    }
}