using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HuluMoviesAndTV.Core.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ProgramTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("4c22297f-bbba-466a-aa6f-d15233d4c2dd"), "TV Show" },
                    { new Guid("4fb52af8-ccf3-4e8a-97aa-02ba41faa959"), "Movie" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProgramTypes",
                keyColumn: "Id",
                keyValue: new Guid("4c22297f-bbba-466a-aa6f-d15233d4c2dd"));

            migrationBuilder.DeleteData(
                table: "ProgramTypes",
                keyColumn: "Id",
                keyValue: new Guid("4fb52af8-ccf3-4e8a-97aa-02ba41faa959"));
        }
    }
}
