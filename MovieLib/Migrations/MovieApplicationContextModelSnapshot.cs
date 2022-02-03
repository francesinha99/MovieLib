﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieLib.Models;

namespace MovieLib.Migrations
{
    [DbContext(typeof(MovieApplicationContext))]
    partial class MovieApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("MovieLib.Models.ApplicationResponse", b =>
                {
                    b.Property<int>("MovieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Responses");

                    b.HasData(
                        new
                        {
                            MovieID = 1,
                            CategoryID = 6,
                            Director = "Ben Stiller",
                            Edited = false,
                            LentTo = "",
                            Notes = "",
                            Rating = "PG",
                            Title = "The Secret Life of Walter Mitty",
                            Year = 2013
                        },
                        new
                        {
                            MovieID = 2,
                            CategoryID = 7,
                            Director = "John Hughes",
                            Edited = false,
                            LentTo = "",
                            Notes = "",
                            Rating = "PG-13",
                            Title = "Ferris Bueller's Day Off",
                            Year = 1986
                        },
                        new
                        {
                            MovieID = 3,
                            CategoryID = 1,
                            Director = "Frank Capra",
                            Edited = false,
                            LentTo = "",
                            Notes = "",
                            Rating = "NR",
                            Title = "It's a Wonderful Life",
                            Year = 1946
                        });
                });

            modelBuilder.Entity("MovieLib.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            CategoryName = "Family"
                        },
                        new
                        {
                            CategoryID = 2,
                            CategoryName = "Horror/Suspense"
                        },
                        new
                        {
                            CategoryID = 3,
                            CategoryName = "Miscellaneous"
                        },
                        new
                        {
                            CategoryID = 4,
                            CategoryName = "Television"
                        },
                        new
                        {
                            CategoryID = 5,
                            CategoryName = "VHS"
                        },
                        new
                        {
                            CategoryID = 6,
                            CategoryName = "Action/Adventure"
                        },
                        new
                        {
                            CategoryID = 7,
                            CategoryName = "Comedy"
                        },
                        new
                        {
                            CategoryID = 8,
                            CategoryName = "Drama"
                        });
                });

            modelBuilder.Entity("MovieLib.Models.ApplicationResponse", b =>
                {
                    b.HasOne("MovieLib.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
