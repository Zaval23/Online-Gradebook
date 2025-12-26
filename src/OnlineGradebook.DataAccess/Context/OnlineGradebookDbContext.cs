using Microsoft.EntityFrameworkCore;
using OnlineGradebook.DataAccess.Entities;
using OnlineGradebook.DataAccess.Context.Configurations;


namespace OnlineGradebook.DataAccess.Context;

public class OnlineGradebookDbContext:DbContext
{
    public DbSet<UserEntity> Users { get; set; }
    public DbSet<RoleEntity> Roles { get; set; }
    public DbSet<StudentEntity> Students { get; set; }
    public DbSet<TeacherEntity> Teachers { get; set; }
    public DbSet<ParentEntity> Parents { get; set; }
    public DbSet<ParentStudentEntity> ParentStudents { get; set; }
    public DbSet<SubjectEntity> Subjects { get; set; }
    public DbSet<DiaryEntryEntity> DiaryEntries { get; set; }

    public OnlineGradebookDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureUserEntity();
        modelBuilder.ConfigureRoleEntity();
        modelBuilder.ConfigureStudentEntity();
        modelBuilder.ConfigureTeacherEntity();
        modelBuilder.ConfigureParentEntity();
        modelBuilder.ConfigureParentStudentEntity();
        modelBuilder.ConfigureSubjectEntity();
        modelBuilder.ConfigureDiaryEntryEntity();
    }
}