using Microsoft.EntityFrameworkCore;

namespace MovieList.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options) { }

        public DbSet<MovieModel> Movies { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovieModel>().HasKey(m => m.MovieId);
            modelBuilder.Entity<MovieModel>().HasData(
                new MovieModel
                {
                    MovieId = 1,
                    Name = "ABC",
                    Year = 1991,
                    Rating = 1,
                },
                new MovieModel
                {
                    MovieId = 2,
                    Name = "CBA",
                    Year = 1992,
                    Rating = 2,
                },
                new MovieModel
                {
                    MovieId = 3,
                    Name = "BCA",
                    Year = 1993,
                    Rating = 3,
                }
                );
        }

    }
}
