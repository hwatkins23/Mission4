using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4.Models
{
    public class MovieContext : DbContext
    {
        // constructor
        public MovieContext (DbContextOptions<MovieContext> options) : base(options)
        {
            // leave blank for now
        }

        public DbSet<FormResponse> responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<FormResponse>().HasData(
                // adds 3 new movies to the database automatically
                new FormResponse
                {
                    MovieID = 1,
                    Title = "Spider-Man: No Way Home",
                    Category = "Action/Adventure",
                    Year = 2021,
                    Director = "Jon Watts",
                    Rating = "PG-13"
                },
                new FormResponse
                {
                    MovieID = 2,
                    Title = "She's The Man",
                    Category = "Comedy",
                    Year = 2006,
                    Director = "Andy Fickman",
                    Rating = "PG-13"
                },
                new FormResponse
                {
                    MovieID = 3,
                    Title = "The Dawn Wall",
                    Category = "Documentary",
                    Year = 2017,
                    Director = "Peter Mortimer and Josh Lowell",
                    Rating = "PG-13"
                }
            );
        }
    }
}
