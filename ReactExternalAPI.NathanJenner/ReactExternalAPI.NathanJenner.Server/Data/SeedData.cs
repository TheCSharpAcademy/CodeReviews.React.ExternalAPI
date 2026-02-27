using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using ReactExternal.API.Models;

namespace ReactExternal.API.Data;

public class SeedData
{
    public static void InitDatabase(IServiceProvider serviceProvider)
    {
        using (var context = new ApplicationDbContext(
            serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
        {
            if (context.Images.Any())
            {
                return;   // DB has already been seeded
            }
            else
            {
                foreach (var image in GetSeedImages())
                {
                    context.Images.Add(image);
                }
                context.SaveChanges();
            }   
        }
    }


    public static List<ImageModel> GetSeedImages()
    {
        return new List<ImageModel>
        {
            new ImageModel
            {
                Title = "Mountain Landscape",
                Description = "A mountain range with a path",
                ImageUrl = "/public/image01.jpg",
                Author = "Henry Johnson"
            },
            new ImageModel
            {
                Title = "Moutain Lake",
                Description = "Lake winding through mountains",
                ImageUrl = "/public/image02.jpg",
                Author = "Sharon Tzlaki"
            },
            new ImageModel
            {
                Title = "Cloudy Night",
                Description = "Dark clouds coming over a beach",
                ImageUrl = "/public/image03.jpg",
                Author = "Kristine Smothersby"
            },
            new ImageModel
            {
                Title = "Rocks at Dusk",
                Description = "Golden light shining on rocks",
                ImageUrl = "/public/image04.jpg",
                Author = "Charlie Bracken"
            },
            new ImageModel
            {
                Title = "Morning",
                Description = "The start of a new day as seen from space",
                ImageUrl = "/public/image05.jpg",
                Author = "Adam Whitely"
            },
            new ImageModel
            {
                Title = "Sisters",
                Description = "Two rock pillars in the surf",
                ImageUrl = "/public/image06.jpg",
                Author = "Elizabeth Nightingale"
            },
            new ImageModel
            {
                Title = "Bear & Cub",
                Description = "Mother bear and her cub",
                ImageUrl = "/public/image07.jpg",
                Author = "Rachel Andrews"
            },
            new ImageModel
            {
                Title = "Foggy Forest",
                Description = "Blanket of fog covering a forest",
                ImageUrl = "/public/image08.jpg",
                Author = "Amir Ramirez"
            }
        };
    }
}

