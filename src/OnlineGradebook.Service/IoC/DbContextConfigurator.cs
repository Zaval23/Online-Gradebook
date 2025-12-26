using Microsoft.EntityFrameworkCore;
using Npgsql; 
using OnlineGradebook.DataAccess.Context;
using OnlineGradebook.Service.Settings;

namespace OnlineGradebook.Service.IoC;

public static class DbContextConfigurator
{
    public static void ConfigureService(IServiceCollection services, OnlineGradebookSettings settings)
    {
        services.AddDbContextFactory<OnlineGradebookDbContext>(options =>
        {
            options.UseNpgsql(settings.OnlineGradebookDbConnectionString);
        }, ServiceLifetime.Scoped);
    }

    public static void ConfigureApplication(IApplicationBuilder app)
    {
        using var scope = app.ApplicationServices.CreateScope();
        var contextFactory = scope.ServiceProvider.GetRequiredService<IDbContextFactory<OnlineGradebookDbContext>>();
        using var context = contextFactory.CreateDbContext();

        
        context.Database.Migrate();
    }

    
}