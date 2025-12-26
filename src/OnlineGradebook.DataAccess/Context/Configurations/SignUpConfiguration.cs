using Microsoft.EntityFrameworkCore;
using OnlineGradebook.DataAccess.Entities;
namespace OnlineGradebook.DataAccess.Context.Configurations;

public static class DiaryEntryConfiguration
{
    public static void ConfigureDiaryEntryEntity(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DiaryEntryEntity>().HasKey(e => e.Id);
        modelBuilder.Entity<DiaryEntryEntity>().HasIndex(x =>x.ExternalId).IsUnique();

        modelBuilder.Entity<DiaryEntryEntity>().Property(e => e.Date).IsRequired();
        
        modelBuilder.Entity<DiaryEntryEntity>().Property(e => e.Grade);
        
        modelBuilder.Entity<DiaryEntryEntity>()
            .ToTable(t => t.HasCheckConstraint("CK_DiaryEntry_Grade", "\"Grade\" >= 1 AND \"Grade\" <= 5 OR \"Grade\" IS NULL"));
        
        modelBuilder.Entity<DiaryEntryEntity>().Property(e => e.Homework).HasMaxLength(1000);
        
        modelBuilder.Entity<DiaryEntryEntity>().Property(e => e.StudentId).IsRequired();
        modelBuilder.Entity<DiaryEntryEntity>().Property(e => e.TeacherId).IsRequired();
        modelBuilder.Entity<DiaryEntryEntity>().Property(e => e.SubjectId).IsRequired();
        
        modelBuilder.Entity<DiaryEntryEntity>().HasOne(e => e.Student)
            .WithMany(s => s.DiaryEntries)
            .HasForeignKey(e => e.StudentId)
            .OnDelete(DeleteBehavior.Restrict);
        
        modelBuilder.Entity<DiaryEntryEntity>().HasOne(e => e.Teacher)
            .WithMany(t => t.DiaryEntries)
            .HasForeignKey(e => e.TeacherId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<DiaryEntryEntity>().HasOne(e => e.Subject)
            .WithMany(s => s.DiaryEntries)
            .HasForeignKey(e => e.SubjectId);
    }
}