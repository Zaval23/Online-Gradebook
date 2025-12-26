using Microsoft.EntityFrameworkCore;
using OnlineGradebook.DataAccess.Entities;

namespace OnlineGradebook.DataAccess.Context.Configurations;

public static class TeacherConfiguration
{
    public static void ConfigureTeacherEntity(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TeacherEntity>().HasKey(x => x.Id);
        modelBuilder.Entity<TeacherEntity>().HasIndex(x => x.ExternalId).IsUnique();
        
        modelBuilder.Entity<TeacherEntity>().Property(x => x.Classroom).IsRequired().HasMaxLength(50);
        
        modelBuilder.Entity<TeacherEntity>().Property(x => x.UserId).IsRequired();
        modelBuilder.Entity<TeacherEntity>().HasIndex(x => x.UserId).IsUnique();
        
        modelBuilder.Entity<TeacherEntity>().HasOne(t => t.User)
            .WithOne(u => u.Teacher)
            .HasForeignKey<TeacherEntity>(t => t.UserId);
    }
}


