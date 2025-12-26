using Microsoft.EntityFrameworkCore;
using OnlineGradebook.DataAccess.Entities;

namespace OnlineGradebook.DataAccess.Context.Configurations;

public static class StudentConfiguration
{
    public static void ConfigureStudentEntity(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<StudentEntity>().HasKey(x => x.Id);
        modelBuilder.Entity<StudentEntity>().HasIndex(x => x.ExternalId).IsUnique();
        
        modelBuilder.Entity<StudentEntity>().Property(x => x.Class).IsRequired().HasMaxLength(50);
        
        modelBuilder.Entity<StudentEntity>().Property(x => x.UserId).IsRequired();
        modelBuilder.Entity<StudentEntity>().HasIndex(x => x.UserId).IsUnique();
        
        modelBuilder.Entity<StudentEntity>().HasOne(s => s.User)
            .WithOne(u => u.Student)
            .HasForeignKey<StudentEntity>(s => s.UserId);
    }
}


