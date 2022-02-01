using System;
using Microsoft.EntityFrameworkCore;

namespace MovieLib.Models
{
    public class MovieApplicationContext : DbContext
    {
        public MovieApplicationContext(DbContextOptions<MovieApplicationContext> options) : base(options)
        {
            //Leave blank for now
        }
        public DbSet<ApplicationResponse> Responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<ApplicationResponse>().HasData(

                new ApplicationResponse
                {
                    MovieID = 1,
                    Category = "Adventure",
                    Title = "The Secret Life of Walter Mitty",
                    Year = 2013,
                    Director = "Ben Stiller",
                    Rating = "PG",
                    Edited = false,
                    LentTo = "",
                    Notes = ""
                },

                new ApplicationResponse
                {
                    MovieID = 2,
                    Category = "Comedy",
                    Title = "Ferris Bueller's Day Off",
                    Year = 1986,
                    Director = "John Hughes",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = ""
                },

                new ApplicationResponse
                {
                    MovieID = 3,
                    Category = "Family",
                    Title = "It's a Wonderful Life",
                    Year = 1946,
                    Director = "Frank Capra",
                    Rating = "NR",
                    Edited = false,
                    LentTo = "",
                    Notes = ""
                }

            );
        }
    }
}
