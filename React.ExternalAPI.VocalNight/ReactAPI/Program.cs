using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.EntityFrameworkCore;
using ReactAPI.Model;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

const string corsPolicy = "any origin";
builder.Services.AddControllers();
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: corsPolicy, policy =>
        policy.WithOrigins("http://localhost:3000"));
});
builder.Services.AddDbContext<APIContext>(opt =>
opt.UseSqlServer(builder.Configuration.GetConnectionString("Database")));
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

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var db = scope.ServiceProvider.GetRequiredService<APIContext>();
    db.Database.EnsureDeleted();
    db.Database.EnsureCreated();
}

app.UseCors(corsPolicy);
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
