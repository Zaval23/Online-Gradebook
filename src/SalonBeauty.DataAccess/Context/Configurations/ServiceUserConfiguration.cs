using Microsoft.EntityFrameworkCore;
using SalonBeauty.DataAccess.Entities;
namespace SalonBeauty.DataAccess.Context.Configurations;

public static class ServiceUserConfiguration
{
    public static void ConfigureServiceUserEntity(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ServiceUserEntity>().HasKey(su => su.Id);
        modelBuilder.Entity<ServiceUserEntity>().HasIndex(x =>x.ExternalId).IsUnique();
        
        modelBuilder.Entity<ServiceUserEntity>().Property(x => x.ServiceId).IsRequired();
        modelBuilder.Entity<ServiceUserEntity>().Property(x => x.UserId).IsRequired();

        modelBuilder.Entity<ServiceUserEntity>().HasOne(su => su.ServiceEntity)
            .WithMany(s => s.ServiceUsers)
            .HasForeignKey(su => su.ServiceId);

        modelBuilder.Entity<ServiceUserEntity>().HasOne(su => su.UserEntity)
            .WithMany(u => u.ServiceUsers)
            .HasForeignKey(su => su.UserId);
    }
}