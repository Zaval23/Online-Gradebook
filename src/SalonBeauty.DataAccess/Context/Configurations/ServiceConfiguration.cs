using Microsoft.EntityFrameworkCore;
using SalonBeauty.DataAccess.Entities;
namespace SalonBeauty.DataAccess.Context.Configurations;

public static class ServiceConfiguration
{
    public static void ConfigureServiceEntity(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ServiceEntity>().HasKey(x => x.Id);
        modelBuilder.Entity<ServiceEntity>().HasIndex(x =>x.ExternalId).IsUnique();
        
        modelBuilder.Entity<ServiceEntity>().Property(x =>x.Name).IsRequired().HasMaxLength(100);
        modelBuilder.Entity<ServiceEntity>().Property(x => x.Price).IsRequired();
    }
}