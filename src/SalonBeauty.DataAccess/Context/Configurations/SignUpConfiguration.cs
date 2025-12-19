using Microsoft.EntityFrameworkCore;
using SalonBeauty.DataAccess.Entities;
namespace SalonBeauty.DataAccess.Context.Configurations;

public static class SignUpConfiguration
{
    public static void ConfigureSignUpEntity(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<SignUpEntity>().HasKey(s => s.Id);
        modelBuilder.Entity<SignUpEntity>().HasIndex(x =>x.ExternalId).IsUnique();

        modelBuilder.Entity<SignUpEntity>().Property(s => s.DateTime).IsRequired();
        modelBuilder.Entity<SignUpEntity>().Property(s => s.ServiceId).IsRequired();
        modelBuilder.Entity<SignUpEntity>().Property(s => s.ClientId).IsRequired();
        modelBuilder.Entity<SignUpEntity>().Property(s => s.MasterId).IsRequired();
        
        modelBuilder.Entity<SignUpEntity>().HasOne(s => s.Client)
            .WithMany(u => u.SignUpsClients)
            .HasForeignKey(s => s.ClientId);
        
        modelBuilder.Entity<SignUpEntity>().HasOne(s => s.Master)
            .WithMany(u => u.SignUpsMasters)
            .HasForeignKey(s => s.MasterId);

        modelBuilder.Entity<SignUpEntity>().HasOne(s => s.ServiceEntity)
            .WithMany(s => s.SignUps)
            .HasForeignKey(s => s.ServiceId);
    }
}