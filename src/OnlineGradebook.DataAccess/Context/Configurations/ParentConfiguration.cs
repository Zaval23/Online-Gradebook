using Microsoft.EntityFrameworkCore;
using OnlineGradebook.DataAccess.Entities;

namespace OnlineGradebook.DataAccess.Context.Configurations;

public static class ParentConfiguration
{
    public static void ConfigureParentEntity(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ParentEntity>().HasKey(x => x.Id);
        modelBuilder.Entity<ParentEntity>().HasIndex(x => x.ExternalId).IsUnique();
        
        modelBuilder.Entity<ParentEntity>().Property(x => x.UserId).IsRequired();
        modelBuilder.Entity<ParentEntity>().HasIndex(x => x.UserId).IsUnique();
        
        modelBuilder.Entity<ParentEntity>().HasOne(p => p.User)
            .WithOne(u => u.Parent)
            .HasForeignKey<ParentEntity>(p => p.UserId);
    }
}


