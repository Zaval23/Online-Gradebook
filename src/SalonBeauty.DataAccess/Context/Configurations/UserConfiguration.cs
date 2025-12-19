using Microsoft.EntityFrameworkCore;
using SalonBeauty.DataAccess.Entities;
namespace SalonBeauty.DataAccess.Context.Configurations;

public static class UserConfiguration
{
    public static void ConfigureUserEntity(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserEntity>().HasKey(x => x.Id);
        modelBuilder.Entity<UserEntity>().HasIndex(x =>x.ExternalId).IsUnique();

        modelBuilder.Entity<UserEntity>().Property(x => x.Name).IsRequired().HasMaxLength(50);
        modelBuilder.Entity<UserEntity>().Property(x => x.Surname).IsRequired().HasMaxLength(50);
        modelBuilder.Entity<UserEntity>().Property(x => x.Patronymic).HasMaxLength(50);
        
        modelBuilder.Entity<UserEntity>().Property(x=>x.Telephone).IsRequired().HasMaxLength(12);
        modelBuilder.Entity<UserEntity>().HasIndex(x=>x.Telephone).IsUnique();
        
        modelBuilder.Entity<UserEntity>().Property(x=>x.Login).IsRequired().HasMaxLength(30);
        modelBuilder.Entity<UserEntity>().HasIndex(x=>x.Login).IsUnique();
    }
}