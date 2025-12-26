using Microsoft.EntityFrameworkCore;
using OnlineGradebook.DataAccess.Entities;
namespace OnlineGradebook.DataAccess.Context.Configurations;

public static class SubjectConfiguration
{
    public static void ConfigureSubjectEntity(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<SubjectEntity>().HasKey(x => x.Id);
        modelBuilder.Entity<SubjectEntity>().HasIndex(x =>x.ExternalId).IsUnique();
        
        modelBuilder.Entity<SubjectEntity>().Property(x => x.NameOfSubject).IsRequired().HasMaxLength(100);
        modelBuilder.Entity<SubjectEntity>().HasIndex(x => x.NameOfSubject).IsUnique();
    }
}