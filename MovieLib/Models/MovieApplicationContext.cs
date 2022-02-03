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
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                    new Category { CategoryID=1, CategoryName="Family" },
                    new Category { CategoryID=2, CategoryName="Horror/Suspense" },
                    new Category { CategoryID =3, CategoryName ="Miscellaneous" },
                    new Category { CategoryID = 4, CategoryName = "Television" },
                    new Category { CategoryID = 5, CategoryName = "VHS" },
                    new Category { CategoryID = 6, CategoryName = "Action/Adventure" },
                    new Category { CategoryID = 7, CategoryName = "Comedy" },
                    new Category { CategoryID = 8, CategoryName = "Drama" }

                );

            mb.Entity<ApplicationResponse>().HasData(

                new ApplicationResponse
                {
                    MovieID = 1,
                    CategoryID = 6,
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
                    CategoryID = 7,
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
                    CategoryID = 1,
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
