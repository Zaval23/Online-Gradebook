using Microsoft.EntityFrameworkCore;
using Npgsql; 
using SalonBeauty.DataAccess.Context;
using SalonBeauty.Service.Settings;

namespace SalonBeauty.Service.IoC;

public static class DbContextConfigurator
{
    public static void ConfigureService(IServiceCollection services, SalonBeautySettings settings)
    {
        services.AddDbContextFactory<SalonBeautyDbContext>(options =>
        {
            options.UseNpgsql(settings.SalonBeautyDbConnectionString);
        }, ServiceLifetime.Scoped);
    }

    public static void ConfigureApplication(IApplicationBuilder app)
    {
        using var scope = app.ApplicationServices.CreateScope();
        var contextFactory = scope.ServiceProvider.GetRequiredService<IDbContextFactory<SalonBeautyDbContext>>();
        using var context = contextFactory.CreateDbContext();

        
        context.Database.Migrate();
    }

    
}