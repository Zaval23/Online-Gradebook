using Microsoft.EntityFrameworkCore;
using SalonBeauty.DataAccess.Entities;

namespace SalonBeauty.DataAccess.Context.Configurations;

public static class ImageConfiguration
{
    public static void ConfigureImageEntity(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ImageEntity>().HasKey(x => x.Id);
        modelBuilder.Entity<ImageEntity>().HasIndex(x => x.ExternalId).IsUnique();

        modelBuilder.Entity<ImageEntity>().Property(x => x.FileName).IsRequired().HasMaxLength(100);
        modelBuilder.Entity<ImageEntity>().Property(x => x.FileExtension).IsRequired().HasMaxLength(50);
        modelBuilder.Entity<ImageEntity>().Property(x => x.Content).IsRequired();
        
        modelBuilder.Entity<ImageEntity>().HasOne(s => s.Service)
            .WithMany(i => i.Images)
            .HasForeignKey(s => s.ServiceId);
    }
}