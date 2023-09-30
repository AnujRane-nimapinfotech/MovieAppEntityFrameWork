using MovieApp.EntityTypeConfigurations;
using System.Data.Entity;

namespace MovieApp
{
    public class MovieAppContext : DbContext
    {
        public MovieAppContext()
        {
        }
        public DbSet<Video> Videos { get; set; }
        public DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new VideoConfiguration());
            modelBuilder.Configurations.Add(new GenreConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
