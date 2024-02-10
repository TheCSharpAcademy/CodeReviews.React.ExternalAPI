using Microsoft.EntityFrameworkCore;

namespace ReactAPI.Model
{
    public class APIContext: DbContext
    {
        public APIContext( DbContextOptions<APIContext> options ) : base(options) { }


        protected override void OnModelCreating( ModelBuilder modelBuilder )
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<GameModel>().HasData(
                    new GameModel { Id = 1, Name = "Tomb Raider", ReleaseDate = "1996", ImageUrl = "https://tombraiders.net/stella/images/timeline/tomb_raider_1_box.jpg" },
                    new GameModel { Id = 2, Name = "Tomb Raider 2", ReleaseDate = "1997", ImageUrl = "https://tombraiders.net/stella/images/timeline/tomb_raider_2_box.jpg" },
                    new GameModel { Id = 3, Name = "Tomb Raider 3", ReleaseDate = "1998", ImageUrl = "https://tombraiders.net/stella/images/timeline/tomb_raider_3_box.jpg" },
                    new GameModel { Id = 4, Name = "Tomb Raider The Last Revelation", ReleaseDate = "1999", ImageUrl = "https://tombraiders.net/stella/images/timeline/tomb_raider_4_box.jpg" }

                );

            }

        public DbSet<GameModel> Games { get; set; }
    }
}
