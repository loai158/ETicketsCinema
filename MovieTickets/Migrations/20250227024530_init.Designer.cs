﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieTickets.Data;

#nullable disable

namespace MovieTickets.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250227024530_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ActorMovie", b =>
                {
                    b.Property<int>("ActorsMovieId")
                        .HasColumnType("int");

                    b.Property<int>("MovieActorsId")
                        .HasColumnType("int");

                    b.HasKey("ActorsMovieId", "MovieActorsId");

                    b.HasIndex("MovieActorsId");

                    b.ToTable("MovieActors", (string)null);
                });

            modelBuilder.Entity("CategoryMovie", b =>
                {
                    b.Property<int>("CategoryMoviesId")
                        .HasColumnType("int");

                    b.Property<int>("MovieCategoriesId")
                        .HasColumnType("int");

                    b.HasKey("CategoryMoviesId", "MovieCategoriesId");

                    b.HasIndex("MovieCategoriesId");

                    b.ToTable("MovieCategories", (string)null);
                });

            modelBuilder.Entity("CinemaMovie", b =>
                {
                    b.Property<int>("CinemaMoviesId")
                        .HasColumnType("int");

                    b.Property<int>("MovieCinemasId")
                        .HasColumnType("int");

                    b.HasKey("CinemaMoviesId", "MovieCinemasId");

                    b.HasIndex("MovieCinemasId");

                    b.ToTable("MovieCinemas", (string)null);
                });

            modelBuilder.Entity("MovieTickets.Models.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("News")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilePicture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Actors");
                });

            modelBuilder.Entity("MovieTickets.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("MovieTickets.Models.Cinema", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CinemaLogo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cinemas");
                });

            modelBuilder.Entity("MovieTickets.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImgUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MovieStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("TrailerUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("ActorMovie", b =>
                {
                    b.HasOne("MovieTickets.Models.Movie", null)
                        .WithMany()
                        .HasForeignKey("ActorsMovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MovieTickets.Models.Actor", null)
                        .WithMany()
                        .HasForeignKey("MovieActorsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CategoryMovie", b =>
                {
                    b.HasOne("MovieTickets.Models.Movie", null)
                        .WithMany()
                        .HasForeignKey("CategoryMoviesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MovieTickets.Models.Category", null)
                        .WithMany()
                        .HasForeignKey("MovieCategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CinemaMovie", b =>
                {
                    b.HasOne("MovieTickets.Models.Movie", null)
                        .WithMany()
                        .HasForeignKey("CinemaMoviesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MovieTickets.Models.Cinema", null)
                        .WithMany()
                        .HasForeignKey("MovieCinemasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
