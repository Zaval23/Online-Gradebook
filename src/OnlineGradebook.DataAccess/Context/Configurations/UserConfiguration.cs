using Microsoft.EntityFrameworkCore;
using OnlineGradebook.DataAccess.Entities;
namespace OnlineGradebook.DataAccess.Context.Configurations;

public static class UserConfiguration
{
    public static void ConfigureUserEntity(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserEntity>().HasKey(x => x.Id);
        modelBuilder.Entity<UserEntity>().HasIndex(x =>x.ExternalId).IsUnique();

        modelBuilder.Entity<UserEntity>().Property(x => x.Email).IsRequired().HasMaxLength(100);
        modelBuilder.Entity<UserEntity>().HasIndex(x => x.Email).IsUnique();
        
        modelBuilder.Entity<UserEntity>().Property(x => x.FirstName).IsRequired().HasMaxLength(50);
        modelBuilder.Entity<UserEntity>().Property(x => x.LastName).IsRequired().HasMaxLength(50);
        modelBuilder.Entity<UserEntity>().Property(x => x.MiddleName).HasMaxLength(50);
        
        modelBuilder.Entity<UserEntity>().Property(x => x.RoleId).IsRequired();
        
        modelBuilder.Entity<UserEntity>().HasOne(u => u.Role)
            .WithMany(r => r.Users)
            .HasForeignKey(u => u.RoleId);
    }
}