using Microsoft.EntityFrameworkCore;
using SalonBeauty.DataAccess.Entities;
using SalonBeauty.DataAccess.Context.Configurations;


namespace SalonBeauty.DataAccess.Context;

public class SalonBeautyDbContext:DbContext
{
    public DbSet<UserEntity> Users { get; set; }
    public DbSet<RoleEntity> Roles { get; set; }
    public DbSet<UserRoleEntity> UsersRoles { get; set; }
    public DbSet<ServiceEntity> Services { get; set; }
    public DbSet<ServiceUserEntity> ServicesUsers { get; set; }
    public DbSet<SignUpEntity> SignUps { get; set; }
    public DbSet<SalonEntity> Salons { get; set; }
    public DbSet<SalonServiceEntity> SalonsServices { get; set; }
    public DbSet<ImageEntity> Images { get; set; }

    public SalonBeautyDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureUserEntity();
        modelBuilder.ConfigureRoleEntity();
        modelBuilder.ConfigureUserRoleEntity();
        modelBuilder.ConfigureServiceEntity();
        modelBuilder.ConfigureServiceUserEntity();
        modelBuilder.ConfigureSignUpEntity();
        modelBuilder.ConfigureSalonEntity();
        modelBuilder.ConfigureSalonServiceEntity();
        modelBuilder.ConfigureImageEntity();
    }
}