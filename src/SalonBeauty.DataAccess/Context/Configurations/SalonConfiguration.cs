using Microsoft.EntityFrameworkCore;
using SalonBeauty.DataAccess.Entities;
namespace SalonBeauty.DataAccess.Context.Configurations;

public static class SalonConfiguration
{
    public static void ConfigureSalonEntity(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<SalonEntity>().HasKey(x => x.Id);
        modelBuilder.Entity<SalonEntity>().HasIndex(x =>x.ExternalId).IsUnique();
        
        modelBuilder.Entity<SalonEntity>().Property(x => x.Adress).IsRequired().HasMaxLength(300);
    }
}