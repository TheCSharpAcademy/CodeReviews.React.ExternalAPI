using ExternalAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ExternalAPI.Data;

public class CarContext : DbContext
{
  public CarContext(DbContextOptions options) : base(options)
  {
  }

  public DbSet<Car> Cars { get; set; }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.Entity<Car>().HasData(
      new Car
      {
        Id = 1,
        Make = "Nissan",
        Model = "Skyline R34 GT-R",
        Hp = 500,
        YearOfRelease = 1999,
        ImageUrl = "https://speedhunters-wp-production.s3.amazonaws.com/wp-content/uploads/2021/07/20205450/Speedhunters_R34roller-3-1200x800.jpg",
        Description = "The Nissan Skyline R34 GT-R is an iconic Japanese sports car renowned for its potent twin-turbo inline-six and timeless design. The Toyota Supra MK4, featuring the legendary 2JZ engine, stands as a symbol of high-performance excellence and distinctive styling in automotive history.",
        WikiLink = "https://en.wikipedia.org/wiki/Nissan_Skyline_GT-R"
      },
      new Car
      {
        Id = 2,
        Make = "Nissan",
        Model = "350Z",
        Hp = 300,
        YearOfRelease = 1995,
        ImageUrl = "https://hips.hearstapps.com/hmg-prod/images/350rear-1513348241.jpeg",
        Description = "The Nissan 350Z delivers a thrilling driving experience with its powerful V6 engine and rear-wheel-drive configuration, while its sleek design and bold curves contribute to its enduring appeal as a modern classic in the world of sports cars.",
        WikiLink = "https://en.wikipedia.org/wiki/Nissan_350Z"
      },
      new Car
      {
        Id = 3,
        Make = "Nissan",
        Model = "200sx",
        Hp = 400,
        YearOfRelease = 1999,
        ImageUrl = "https://i.redd.it/tudob7j67ev41.jpg",
        Description = "The Nissan 200SX, part of the S platform series, is a compact and sporty coupe celebrated for its agile handling and varied engine options, offering a balance of power and efficiency. Recognized for its sleek, aerodynamic design, the 200SX remains a beloved choice among enthusiasts for its sporty appeal and tunable capabilities.",
        WikiLink = "https://en.wikipedia.org/wiki/Nissan_200SX"
      },
      new Car
      {
        Id = 4,
        Make = "Toyota",
        Model = "Supra MK4",
        Hp = 1200,
        YearOfRelease = 1999,
        ImageUrl = "https://ronbrooks.b-cdn.net/wp-content/uploads/2023/06/toyota-supra-mk4.png",
        Description = "The Toyota Supra MK4, an automotive legend, is distinguished by its powerful 2JZ inline-six engine, rear-wheel-drive layout, and iconic styling. Renowned for its exceptional performance on both the street and the racetrack, the Supra MK4 has achieved cult status among enthusiasts for its cutting-edge technology and enduring appeal.",
        WikiLink = "https://en.wikipedia.org/wiki/Toyota_Supra"
      },
      new Car
      {
        Id = 5,
        Make = "Toytoa",
        Model = "Sprinter Trueno AE86",
        Hp = 180,
        YearOfRelease = 1998,
        ImageUrl = "https://cdn.arstechnica.net/wp-content/uploads/2023/01/20230113_01_01_s.jpg",
        Description = "The Toyota AE86, a compact and nimble sports car, is celebrated for its lightweight chassis and agile handling, particularly in drifting culture. Part of the Corolla Levin and Sprinter Trueno lineup, the AE86's iconic design and association with motorsports have solidified its status as a cult classic among automotive enthusiasts.",
        WikiLink = "https://en.wikipedia.org/wiki/Toyota_AE86"
      }
      );
    base.OnModelCreating(modelBuilder);

  }
}
