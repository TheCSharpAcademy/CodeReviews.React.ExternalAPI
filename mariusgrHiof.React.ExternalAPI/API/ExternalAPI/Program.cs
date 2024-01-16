using ExternalAPI.Data;
using ExternalAPI.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
  options.AddPolicy("Cors", policy =>
  {
    policy
    .AllowAnyHeader()
    .AllowAnyMethod()
    .AllowAnyOrigin();
  });
});

// Add services to the container.
builder.Services.AddDbContext<CarContext>(options =>
{
  options.UseSqlServer(builder.Configuration.GetConnectionString("CarsConnectionString"));
});

builder.Services.AddScoped<ICarRepository, CarRepository>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
  app.UseSwagger();
  app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("Cors");

app.UseAuthorization();

app.MapControllers();

app.Run();
