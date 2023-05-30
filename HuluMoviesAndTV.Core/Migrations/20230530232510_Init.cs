using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HuluMoviesAndTV.Core.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Directors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Directors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Listeneds",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Listeneds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProgramTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgramTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReleaseYears",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReleaseYears", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MovieAndShows",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    YearId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DirectorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    RatingId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieAndShows", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MovieAndShows_Directors_DirectorId",
                        column: x => x.DirectorId,
                        principalTable: "Directors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MovieAndShows_ProgramTypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "ProgramTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieAndShows_Ratings_RatingId",
                        column: x => x.RatingId,
                        principalTable: "Ratings",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MovieAndShows_ReleaseYears_YearId",
                        column: x => x.YearId,
                        principalTable: "ReleaseYears",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CountryMovieAndShow",
                columns: table => new
                {
                    CountryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MovieAndShowsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryMovieAndShow", x => new { x.CountryId, x.MovieAndShowsId });
                    table.ForeignKey(
                        name: "FK_CountryMovieAndShow_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CountryMovieAndShow_MovieAndShows_MovieAndShowsId",
                        column: x => x.MovieAndShowsId,
                        principalTable: "MovieAndShows",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ListenedMovieAndShow",
                columns: table => new
                {
                    ListenedId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MovieAndShowsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListenedMovieAndShow", x => new { x.ListenedId, x.MovieAndShowsId });
                    table.ForeignKey(
                        name: "FK_ListenedMovieAndShow_Listeneds_ListenedId",
                        column: x => x.ListenedId,
                        principalTable: "Listeneds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ListenedMovieAndShow_MovieAndShows_MovieAndShowsId",
                        column: x => x.MovieAndShowsId,
                        principalTable: "MovieAndShows",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CountryMovieAndShow_MovieAndShowsId",
                table: "CountryMovieAndShow",
                column: "MovieAndShowsId");

            migrationBuilder.CreateIndex(
                name: "IX_ListenedMovieAndShow_MovieAndShowsId",
                table: "ListenedMovieAndShow",
                column: "MovieAndShowsId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieAndShows_DirectorId",
                table: "MovieAndShows",
                column: "DirectorId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieAndShows_RatingId",
                table: "MovieAndShows",
                column: "RatingId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieAndShows_TypeId",
                table: "MovieAndShows",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieAndShows_YearId",
                table: "MovieAndShows",
                column: "YearId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CountryMovieAndShow");

            migrationBuilder.DropTable(
                name: "ListenedMovieAndShow");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Listeneds");

            migrationBuilder.DropTable(
                name: "MovieAndShows");

            migrationBuilder.DropTable(
                name: "Directors");

            migrationBuilder.DropTable(
                name: "ProgramTypes");

            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "ReleaseYears");
        }
    }
}
