using Microsoft.EntityFrameworkCore;
using PokemonAPI.Database;
using PokemonAPI.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddDbContext<PokemonContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("PokemonApi") ?? throw new InvalidOperationException("Connection String not found")));

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IPokemonRepository, PokemonRepository>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    using var scope = app.Services.CreateScope();
    SeedDatabase.Seed(scope.ServiceProvider.GetRequiredService<PokemonContext>());
}

app.UseCors(options => 
    options.AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader()
);


app.UseHttpsRedirection();

app.MapControllers();

app.Run();