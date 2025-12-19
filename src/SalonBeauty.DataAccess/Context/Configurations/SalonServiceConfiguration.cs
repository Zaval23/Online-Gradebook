using Microsoft.EntityFrameworkCore;
using SalonBeauty.DataAccess.Entities;

namespace SalonBeauty.DataAccess.Context.Configurations;

public static class SalonServiceConfiguration
{
    public static void ConfigureSalonServiceEntity(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<SalonServiceEntity>().HasKey(s => s.Id);
        modelBuilder.Entity<SalonServiceEntity>().HasIndex(x =>x.ExternalId).IsUnique();

        modelBuilder.Entity<SalonServiceEntity>().Property(x=>x.SalonId).IsRequired();
        modelBuilder.Entity<SalonServiceEntity>().Property(x=>x.ServiceId).IsRequired();
        
        modelBuilder.Entity<SalonServiceEntity>().HasOne(s =>s.SalonEntity)
            .WithMany(i => i.SalonServices)
            .HasForeignKey(s => s.SalonId);
        
        modelBuilder.Entity<SalonServiceEntity>().HasOne(s => s.ServiceEntity)
            .WithMany(s =>s.SalonServices)
            .HasForeignKey(s => s.ServiceId);
    }
}