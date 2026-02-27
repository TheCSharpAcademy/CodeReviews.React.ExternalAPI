using Microsoft.EntityFrameworkCore;
using ReactExternal.API.Data;
using ReactExternal.API.Models;

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                      policy.WithOrigins("https://localhost:51703");             
                      });
});

builder.Services.AddOpenApi();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

app.UseDefaultFiles();
app.MapStaticAssets();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

// < --- Creating & seeding the database --- > //
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var db = services.GetRequiredService<ApplicationDbContext>();

    if (app.Environment.IsDevelopment())
    {
        db.Database.EnsureCreated();
    }

    SeedData.InitDatabase(services);
}

app.UseHttpsRedirection();
app.UseCors(MyAllowSpecificOrigins);

// < --- Endpoint(s) logic --- > //
app.MapGet("/images", async (ApplicationDbContext db) => await db.Images.ToListAsync());

app.MapGet("/images/{id}", async (int id, ApplicationDbContext db) =>
{
    var image = await db.Images.FindAsync(id);
    return image is not null ? Results.Ok(image) : Results.NotFound();
});

// TODO: add call to external API to retreive data


app.MapFallbackToFile("/index.html");

app.Run();
