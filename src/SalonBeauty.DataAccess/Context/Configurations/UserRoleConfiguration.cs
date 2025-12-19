using Microsoft.EntityFrameworkCore;
using SalonBeauty.DataAccess.Entities;
namespace SalonBeauty.DataAccess.Context.Configurations;

public static class UserRoleConfiguration
{
    public static void ConfigureUserRoleEntity(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserRoleEntity>().HasKey(ur => ur.Id);
        
        modelBuilder.Entity<UserRoleEntity>().HasOne(ur => ur.UserEntity)
            .WithMany(ur=>ur.UserRoles)
            .HasForeignKey(ur => ur.UserId);
        
        modelBuilder.Entity<UserRoleEntity>().HasOne(ur => ur.RoleEntity)
            .WithMany(ur=>ur.UserRoles)
            .HasForeignKey(ur => ur.RoleId);
    }
}