using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace LDSMovies.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new LDSMoviesContext(
                serviceProvider.GetRequiredService<DbContextOptions<LDSMoviesContext>>()))
            {
                // Look for any movies.
                if (context.movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.movie.AddRange(
                     new movie
                     {
                         Title = "Pride and Prejudice",
                         ReleaseDate = DateTime.Parse("2003-12-05"),
                         Genre = "Romantic Comedy",
                         Rating = "G",
                         Price = 13.99M
                     },

                     new movie
                     {
                         Title = "The Best Two Years",
                         ReleaseDate = DateTime.Parse("2004-2-20"),
                         Genre = "Comedy",
                         Rating = "G",
                         Price = 15.99M
                     },

                     new movie
                     {
                         Title = "The R.M.",
                         ReleaseDate = DateTime.Parse("2003-1-31"),
                         Genre = "Comedy",
                         Rating = "G",
                         Price = 8.00M
                     },

                   new movie
                   {
                       Title = "The Singles Ward",
                       ReleaseDate = DateTime.Parse("2002-1-30"),
                       Genre = "Romantic Comedy",
                       Rating = "G",
                       Price = 12.99M
                   }
                );
                context.SaveChanges();
            }
        }
    }
}