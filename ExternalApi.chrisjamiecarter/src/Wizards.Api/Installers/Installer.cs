using Microsoft.EntityFrameworkCore;
using Wizards.Api.Data;
using Wizards.Api.Services;

namespace Wizards.Api.Installers;

/// <summary>
/// Registers dependencies and adds any required middleware.
/// </summary>
public static class Installer
{
    public static IServiceCollection AddApi(this IServiceCollection services, IConfigurationRoot configuration)
    {
        var connectionString = configuration.GetConnectionString("Wizards") ?? throw new InvalidOperationException("Connection string 'Wizards' not found");

        services.AddDbContext<WizardsDataContext>(options =>
        {
            options.UseSqlServer(connectionString);
        });

        services.AddTransient<ISeederService, SeederService>();

        services.AddControllers();

        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        return services;
    }

    public static WebApplication AddMiddleware(this WebApplication app)
    {
        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseCors(options =>
        {
            options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
        });

        app.MapControllers();

        return app;
    }

    public static WebApplication SetUpDatabase(this WebApplication app)
    {
        // Performs any database migrations and seeds the database.
        using var scope = app.Services.CreateScope();
        var services = scope.ServiceProvider;
        services.SeedDatabase();

        return app;
    }

    public static IServiceProvider SeedDatabase(this IServiceProvider serviceProvider)
    {
        var context = serviceProvider.GetRequiredService<WizardsDataContext>();
        context.Database.Migrate();

        var seeder = serviceProvider.GetRequiredService<ISeederService>();
        seeder.SeedDatabase();

        return serviceProvider;
    }
}
