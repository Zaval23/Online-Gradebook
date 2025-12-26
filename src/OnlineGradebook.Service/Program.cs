using OnlineGradebook.Service.IoC;
using OnlineGradebook.Service.Settings;

var configuration = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json", optional: false)
    .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Production"}.json", optional: true)
    .Build();

var settings = OnlineGradebookSettingsReader.Read(configuration);

var builder = WebApplication.CreateBuilder(args);

// Регистрация сервисов
DbContextConfigurator.ConfigureService(builder.Services, settings);
SerilogConfigurator.ConfigureServices(builder);
SwaggerConfigurator.ConfigureServices(builder.Services);

// ДОБАВЬТЕ ЭТО, если используете контроллеры:
builder.Services.AddControllers();

var app = builder.Build();

// Middleware
DbContextConfigurator.ConfigureApplication(app);
SerilogConfigurator.ConfigureApplication(app);
SwaggerConfigurator.ConfigureApplication(app);

app.UseHttpsRedirection();

// ДОБАВЬТЕ ЭТО:
app.MapGet("/", () => "✅ Online-Gradebook API is running!"); // Проверка работоспособности
app.MapControllers(); // Если используете контроллеры

app.Run();