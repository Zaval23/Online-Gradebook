using Microsoft.EntityFrameworkCore;
using OnlineGradebook.DataAccess.Entities;

namespace OnlineGradebook.DataAccess.Context.Configurations;

public static class ParentStudentConfiguration
{
    public static void ConfigureParentStudentEntity(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ParentStudentEntity>().HasKey(x => x.Id);
        modelBuilder.Entity<ParentStudentEntity>().HasIndex(x => x.ExternalId).IsUnique();
        
        modelBuilder.Entity<ParentStudentEntity>().Property(x => x.ParentId).IsRequired();
        modelBuilder.Entity<ParentStudentEntity>().Property(x => x.StudentId).IsRequired();
        
        modelBuilder.Entity<ParentStudentEntity>().HasOne(ps => ps.Parent)
            .WithMany(p => p.ParentStudents)
            .HasForeignKey(ps => ps.ParentId);
        
        modelBuilder.Entity<ParentStudentEntity>().HasOne(ps => ps.Student)
            .WithMany(s => s.ParentStudents)
            .HasForeignKey(ps => ps.StudentId);
    }
}


