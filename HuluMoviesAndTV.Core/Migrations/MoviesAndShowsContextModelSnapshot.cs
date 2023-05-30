﻿// <auto-generated />
using System;
using HuluMoviesAndTV.Core.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HuluMoviesAndTV.Core.Migrations
{
    [DbContext(typeof(MoviesAndShowsContext))]
    partial class MoviesAndShowsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CountryMovieAndShow", b =>
                {
                    b.Property<Guid>("CountryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MovieAndShowsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CountryId", "MovieAndShowsId");

                    b.HasIndex("MovieAndShowsId");

                    b.ToTable("CountryMovieAndShow");
                });

            modelBuilder.Entity("HuluMoviesAndTV.Core.Entity.Country", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("HuluMoviesAndTV.Core.Entity.Director", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Directors");
                });

            modelBuilder.Entity("HuluMoviesAndTV.Core.Entity.Listened", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Listeneds");
                });

            modelBuilder.Entity("HuluMoviesAndTV.Core.Entity.MovieAndShow", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("DirectorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Duration")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("RatingId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("TypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("YearId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("DirectorId");

                    b.HasIndex("RatingId");

                    b.HasIndex("TypeId");

                    b.HasIndex("YearId");

                    b.ToTable("MovieAndShows");
                });

            modelBuilder.Entity("HuluMoviesAndTV.Core.Entity.ProgramType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProgramTypes");
                });

            modelBuilder.Entity("HuluMoviesAndTV.Core.Entity.Rating", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("HuluMoviesAndTV.Core.Entity.ReleaseYear", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ReleaseYears");
                });

            modelBuilder.Entity("ListenedMovieAndShow", b =>
                {
                    b.Property<Guid>("ListenedId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MovieAndShowsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ListenedId", "MovieAndShowsId");

                    b.HasIndex("MovieAndShowsId");

                    b.ToTable("ListenedMovieAndShow");
                });

            modelBuilder.Entity("CountryMovieAndShow", b =>
                {
                    b.HasOne("HuluMoviesAndTV.Core.Entity.Country", null)
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HuluMoviesAndTV.Core.Entity.MovieAndShow", null)
                        .WithMany()
                        .HasForeignKey("MovieAndShowsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HuluMoviesAndTV.Core.Entity.MovieAndShow", b =>
                {
                    b.HasOne("HuluMoviesAndTV.Core.Entity.Director", "Director")
                        .WithMany("MovieAndShows")
                        .HasForeignKey("DirectorId");

                    b.HasOne("HuluMoviesAndTV.Core.Entity.Rating", "Rating")
                        .WithMany("MovieAndShows")
                        .HasForeignKey("RatingId");

                    b.HasOne("HuluMoviesAndTV.Core.Entity.ProgramType", "Type")
                        .WithMany("MovieAndShows")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HuluMoviesAndTV.Core.Entity.ReleaseYear", "Year")
                        .WithMany("MovieAndShows")
                        .HasForeignKey("YearId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Director");

                    b.Navigation("Rating");

                    b.Navigation("Type");

                    b.Navigation("Year");
                });

            modelBuilder.Entity("ListenedMovieAndShow", b =>
                {
                    b.HasOne("HuluMoviesAndTV.Core.Entity.Listened", null)
                        .WithMany()
                        .HasForeignKey("ListenedId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HuluMoviesAndTV.Core.Entity.MovieAndShow", null)
                        .WithMany()
                        .HasForeignKey("MovieAndShowsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HuluMoviesAndTV.Core.Entity.Director", b =>
                {
                    b.Navigation("MovieAndShows");
                });

            modelBuilder.Entity("HuluMoviesAndTV.Core.Entity.ProgramType", b =>
                {
                    b.Navigation("MovieAndShows");
                });

            modelBuilder.Entity("HuluMoviesAndTV.Core.Entity.Rating", b =>
                {
                    b.Navigation("MovieAndShows");
                });

            modelBuilder.Entity("HuluMoviesAndTV.Core.Entity.ReleaseYear", b =>
                {
                    b.Navigation("MovieAndShows");
                });
#pragma warning restore 612, 618
        }
    }
}
