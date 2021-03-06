// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission4.Models;

namespace Mission4.Migrations
{
    [DbContext(typeof(MovieContext))]
    partial class MovieContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("Mission4.Models.FormResponse", b =>
                {
                    b.Property<int>("MovieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Lent")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(40);

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieID");

                    b.ToTable("responses");

                    b.HasData(
                        new
                        {
                            MovieID = 1,
                            Category = "Action/Adventure",
                            Director = "Jon Watts",
                            Edited = false,
                            Rating = "PG-13",
                            Title = "Spider-Man: No Way Home",
                            Year = 2021
                        },
                        new
                        {
                            MovieID = 2,
                            Category = "Comedy",
                            Director = "Andy Fickman",
                            Edited = false,
                            Rating = "PG-13",
                            Title = "She's The Man",
                            Year = 2006
                        },
                        new
                        {
                            MovieID = 3,
                            Category = "Documentary",
                            Director = "Peter Mortimer and Josh Lowell",
                            Edited = false,
                            Rating = "PG-13",
                            Title = "The Dawn Wall",
                            Year = 2017
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
